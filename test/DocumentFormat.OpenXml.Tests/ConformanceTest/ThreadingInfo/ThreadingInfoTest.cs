﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Tests.ChartTrackingRefBasedClass;
using DocumentFormat.OpenXml.Tests.TaskLibraries;
using OxTest;
using System;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace DocumentFormat.OpenXml.Tests.ThreadingInfo
{
    public class ThreadingInfoTest : OpenXmlTestBase
    {
        private readonly string generateDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".pptx");
        private readonly string editDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".pptx");
        private readonly string deleteDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".pptx");
        private readonly string addDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".pptx");
        private readonly TestEntities testEntities;

        /// <summary>
        /// Constructor
        /// </summary>
        public ThreadingInfoTest(ITestOutputHelper output)
            : base(output)
        {
            string createFilePath = GetTestFilePath(generateDocumentFile);
            GeneratedDocument generatedDocument = new GeneratedDocument();
            generatedDocument.CreatePackage(createFilePath);

            Log.Pass("Create Power Point file. File path=[{0}]", createFilePath);

            testEntities = new TestEntities(createFilePath);
        }

        /// <summary>
        /// Element editing test for PresentationExtensionList element
        /// </summary>
        [Fact]
        public void ThreadingInfo01EditElement()
        {
            string originalFilepath = GetTestFilePath(generateDocumentFile);
            string editFilePath = GetTestFilePath(editDocumentFile);

            System.IO.File.Copy(originalFilepath, editFilePath, true);

            testEntities.EditElements(editFilePath, Log);
            testEntities.VerifyElements(editFilePath, Log);
        }

        /// <summary>
        /// Element deleting test for PresentationExtensionList element
        /// </summary>
        [Fact]
        public void ThreadingInfo03DeleteAddElement()
        {
            string originalFilepath = GetTestFilePath(generateDocumentFile);
            string deleteFilePath = GetTestFilePath(deleteDocumentFile);
            string addFilePath = GetTestFilePath(addDocumentFile);

            System.IO.File.Copy(originalFilepath, deleteFilePath, true);

            testEntities.DeleteElements(deleteFilePath, Log);
            testEntities.VerifyDeleteElements(deleteFilePath, Log);

            System.IO.File.Copy(deleteFilePath, addFilePath, true);

            testEntities.AddElements(addFilePath, Log);
            testEntities.VerifyAddElements(addFilePath, Log);
        }
    }
}
