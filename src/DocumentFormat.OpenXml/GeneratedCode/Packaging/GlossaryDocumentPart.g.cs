﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the GlossaryDocumentPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2007)]
    [ContentType(ContentTypeConstant)]
    public partial class GlossaryDocumentPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.wordprocessingml.document.glossary+xml";
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/glossaryDocument";
        private static PartConstraintCollection _dataPartConstraints;
        private static PartConstraintCollection _partConstraints;

        /// <summary>
        /// Creates an instance of the GlossaryDocumentPart OpenXmlType
        /// </summary>
        internal protected GlossaryDocumentPart()
        {
        }

        /// <summary>
        /// Gets the AlternativeFormatImportParts of the GlossaryDocumentPart
        /// </summary>
        public IEnumerable<AlternativeFormatImportPart> AlternativeFormatImportParts => GetPartsOfType<AlternativeFormatImportPart>();

        /// <summary>
        /// Gets the ChartParts of the GlossaryDocumentPart
        /// </summary>
        public IEnumerable<ChartPart> ChartParts => GetPartsOfType<ChartPart>();

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <summary>
        /// Gets the CustomizationPart of the GlossaryDocumentPart
        /// </summary>
        public CustomizationPart CustomizationPart => GetSubPartOfType<CustomizationPart>();

        /// <inheritdoc/>
        internal sealed override PartConstraintCollection DataPartReferenceConstraints
        {
            get
            {
                if (_dataPartConstraints is null)
                {
                    _dataPartConstraints = new PartConstraintCollection
                    {
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/video",
                            PartConstraintRule.Create<VideoReferenceRelationship>(false, true)
                        }
                    };
                }

                return _dataPartConstraints;
            }
        }

        /// <summary>
        /// Gets the DiagramColorsParts of the GlossaryDocumentPart
        /// </summary>
        public IEnumerable<DiagramColorsPart> DiagramColorsParts => GetPartsOfType<DiagramColorsPart>();

        /// <summary>
        /// Gets the DiagramDataParts of the GlossaryDocumentPart
        /// </summary>
        public IEnumerable<DiagramDataPart> DiagramDataParts => GetPartsOfType<DiagramDataPart>();

        /// <summary>
        /// Gets the DiagramLayoutDefinitionParts of the GlossaryDocumentPart
        /// </summary>
        public IEnumerable<DiagramLayoutDefinitionPart> DiagramLayoutDefinitionParts => GetPartsOfType<DiagramLayoutDefinitionPart>();

        /// <summary>
        /// Gets the DiagramPersistLayoutParts of the GlossaryDocumentPart
        /// </summary>
        public IEnumerable<DiagramPersistLayoutPart> DiagramPersistLayoutParts => GetPartsOfType<DiagramPersistLayoutPart>();

        /// <summary>
        /// Gets the DiagramStyleParts of the GlossaryDocumentPart
        /// </summary>
        public IEnumerable<DiagramStylePart> DiagramStyleParts => GetPartsOfType<DiagramStylePart>();

        /// <summary>
        /// Gets the DocumentSettingsPart of the GlossaryDocumentPart
        /// </summary>
        public DocumentSettingsPart DocumentSettingsPart => GetSubPartOfType<DocumentSettingsPart>();

        /// <summary>
        /// Gets the EmbeddedControlPersistenceParts of the GlossaryDocumentPart
        /// </summary>
        public IEnumerable<EmbeddedControlPersistencePart> EmbeddedControlPersistenceParts => GetPartsOfType<EmbeddedControlPersistencePart>();

        /// <summary>
        /// Gets the EmbeddedObjectParts of the GlossaryDocumentPart
        /// </summary>
        public IEnumerable<EmbeddedObjectPart> EmbeddedObjectParts => GetPartsOfType<EmbeddedObjectPart>();

        /// <summary>
        /// Gets the EmbeddedPackageParts of the GlossaryDocumentPart
        /// </summary>
        public IEnumerable<EmbeddedPackagePart> EmbeddedPackageParts => GetPartsOfType<EmbeddedPackagePart>();

        /// <summary>
        /// Gets the EndnotesPart of the GlossaryDocumentPart
        /// </summary>
        public EndnotesPart EndnotesPart => GetSubPartOfType<EndnotesPart>();

        /// <summary>
        /// Gets the FontTablePart of the GlossaryDocumentPart
        /// </summary>
        public FontTablePart FontTablePart => GetSubPartOfType<FontTablePart>();

        /// <summary>
        /// Gets the FooterParts of the GlossaryDocumentPart
        /// </summary>
        public IEnumerable<FooterPart> FooterParts => GetPartsOfType<FooterPart>();

        /// <summary>
        /// Gets the FootnotesPart of the GlossaryDocumentPart
        /// </summary>
        public FootnotesPart FootnotesPart => GetSubPartOfType<FootnotesPart>();

        /// <summary>
        /// Gets the HeaderParts of the GlossaryDocumentPart
        /// </summary>
        public IEnumerable<HeaderPart> HeaderParts => GetPartsOfType<HeaderPart>();

        /// <summary>
        /// Gets the ImageParts of the GlossaryDocumentPart
        /// </summary>
        public IEnumerable<ImagePart> ImageParts => GetPartsOfType<ImagePart>();

        /// <inheritdoc/>
        internal sealed override bool IsContentTypeFixed => true;

        /// <summary>
        /// Gets the NumberingDefinitionsPart of the GlossaryDocumentPart
        /// </summary>
        public NumberingDefinitionsPart NumberingDefinitionsPart => GetSubPartOfType<NumberingDefinitionsPart>();

        /// <inheritdoc/>
        internal sealed override PartConstraintCollection PartConstraints
        {
            get
            {
                if (_partConstraints is null)
                {
                    _partConstraints = new PartConstraintCollection
                    {
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/comments",
                            PartConstraintRule.Create<WordprocessingCommentsPart>(false, false)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/settings",
                            PartConstraintRule.Create<DocumentSettingsPart>(false, false)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/endnotes",
                            PartConstraintRule.Create<EndnotesPart>(false, false)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/fontTable",
                            PartConstraintRule.Create<FontTablePart>(false, false)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/footnotes",
                            PartConstraintRule.Create<FootnotesPart>(false, false)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/numbering",
                            PartConstraintRule.Create<NumberingDefinitionsPart>(false, false)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/styles",
                            PartConstraintRule.Create<StyleDefinitionsPart>(false, false)
                        },
                        {
                            "http://schemas.microsoft.com/office/2007/relationships/stylesWithEffects",
                            PartConstraintRule.Create<StylesWithEffectsPart>(false, false)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/webSettings",
                            PartConstraintRule.Create<WebSettingsPart>(false, false)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/footer",
                            PartConstraintRule.Create<FooterPart>(false, true)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/header",
                            PartConstraintRule.Create<HeaderPart>(false, true)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/printerSettings",
                            PartConstraintRule.Create<WordprocessingPrinterSettingsPart>(false, true)
                        },
                        {
                            "http://schemas.microsoft.com/office/2006/relationships/keyMapCustomizations",
                            PartConstraintRule.Create<CustomizationPart>(false, false)
                        },
                        {
                            "http://schemas.microsoft.com/office/2006/relationships/vbaProject",
                            PartConstraintRule.Create<VbaProjectPart>(false, false)
                        },
                        {
                            "http://schemas.microsoft.com/office/2011/relationships/commentsExtended",
                            PartConstraintRule.Create<WordprocessingCommentsExPart>(false, false)
                        },
                        {
                            "http://schemas.microsoft.com/office/2011/relationships/people",
                            PartConstraintRule.Create<WordprocessingPeoplePart>(false, false)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/aFChunk",
                            PartConstraintRule.Create<AlternativeFormatImportPart>(false, true)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart",
                            PartConstraintRule.Create<ChartPart>(false, true)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramColors",
                            PartConstraintRule.Create<DiagramColorsPart>(false, true)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramData",
                            PartConstraintRule.Create<DiagramDataPart>(false, true)
                        },
                        {
                            "http://schemas.microsoft.com/office/2007/relationships/diagramDrawing",
                            PartConstraintRule.Create<DiagramPersistLayoutPart>(false, true)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramLayout",
                            PartConstraintRule.Create<DiagramLayoutDefinitionPart>(false, true)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle",
                            PartConstraintRule.Create<DiagramStylePart>(false, true)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/control",
                            PartConstraintRule.Create<EmbeddedControlPersistencePart>(false, true)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject",
                            PartConstraintRule.Create<EmbeddedObjectPart>(false, true)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/package",
                            PartConstraintRule.Create<EmbeddedPackagePart>(false, true)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image",
                            PartConstraintRule.Create<ImagePart>(false, true)
                        }
                    };
                }

                return _partConstraints;
            }
        }

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <summary>
        /// Gets the StyleDefinitionsPart of the GlossaryDocumentPart
        /// </summary>
        public StyleDefinitionsPart StyleDefinitionsPart => GetSubPartOfType<StyleDefinitionsPart>();

        /// <summary>
        /// Gets the StylesWithEffectsPart of the GlossaryDocumentPart
        /// </summary>
        public StylesWithEffectsPart StylesWithEffectsPart => GetSubPartOfType<StylesWithEffectsPart>();

        /// <inheritdoc/>
        internal sealed override string TargetName => "document";

        /// <inheritdoc/>
        internal sealed override string TargetPath => "glossary";

        /// <summary>
        /// Gets the VbaProjectPart of the GlossaryDocumentPart
        /// </summary>
        public VbaProjectPart VbaProjectPart => GetSubPartOfType<VbaProjectPart>();

        /// <summary>
        /// Gets the WebSettingsPart of the GlossaryDocumentPart
        /// </summary>
        public WebSettingsPart WebSettingsPart => GetSubPartOfType<WebSettingsPart>();

        /// <summary>
        /// Gets the WordprocessingCommentsExPart of the GlossaryDocumentPart
        /// </summary>
        public WordprocessingCommentsExPart WordprocessingCommentsExPart => GetSubPartOfType<WordprocessingCommentsExPart>();

        /// <summary>
        /// Gets the WordprocessingCommentsPart of the GlossaryDocumentPart
        /// </summary>
        public WordprocessingCommentsPart WordprocessingCommentsPart => GetSubPartOfType<WordprocessingCommentsPart>();

        /// <summary>
        /// Gets the WordprocessingPeoplePart of the GlossaryDocumentPart
        /// </summary>
        public WordprocessingPeoplePart WordprocessingPeoplePart => GetSubPartOfType<WordprocessingPeoplePart>();

        /// <summary>
        /// Gets the WordprocessingPrinterSettingsParts of the GlossaryDocumentPart
        /// </summary>
        public IEnumerable<WordprocessingPrinterSettingsPart> WordprocessingPrinterSettingsParts => GetPartsOfType<WordprocessingPrinterSettingsPart>();

        /// <summary>
        /// Adds a AlternativeFormatImportPart to the GlossaryDocumentPart
        /// </summary>
        /// <param name="contentType">The content type of the AlternativeFormatImportPart</param>
        /// <return>The newly added part</return>
        public AlternativeFormatImportPart AddAlternativeFormatImportPart(string contentType)
        {
            var childPart = new AlternativeFormatImportPart();
            InitPart(childPart, contentType);
            return childPart;
        }

        /// <summary>
        /// Adds a AlternativeFormatImportPart to the GlossaryDocumentPart
        /// </summary>
        /// <param name="contentType">The content type of the AlternativeFormatImportPart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public AlternativeFormatImportPart AddAlternativeFormatImportPart(string contentType, string id)
        {
            var childPart = new AlternativeFormatImportPart();
            InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds a AlternativeFormatImportPart to the GlossaryDocumentPart
        /// </summary>
        /// <param name="partType">The part type of the AlternativeFormatImportPart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public AlternativeFormatImportPart AddAlternativeFormatImportPart(AlternativeFormatImportPartType partType, string id)
        {
            var contentType = AlternativeFormatImportPartTypeInfo.GetContentType(partType);
            var partExtension = AlternativeFormatImportPartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddAlternativeFormatImportPart(contentType, id);
        }

        /// <summary>
        /// Adds a AlternativeFormatImportPart to the GlossaryDocumentPart
        /// </summary>
        /// <param name="partType">The part type of the AlternativeFormatImportPart</param>
        /// <return>The newly added part</return>
        public AlternativeFormatImportPart AddAlternativeFormatImportPart(AlternativeFormatImportPartType partType)
        {
            var contentType = AlternativeFormatImportPartTypeInfo.GetContentType(partType);
            var partExtension = AlternativeFormatImportPartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddAlternativeFormatImportPart(contentType);
        }

        /// <summary>
        /// Adds a EmbeddedControlPersistencePart to the GlossaryDocumentPart
        /// </summary>
        /// <param name="contentType">The content type of the EmbeddedControlPersistencePart</param>
        /// <return>The newly added part</return>
        public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(string contentType)
        {
            var childPart = new EmbeddedControlPersistencePart();
            InitPart(childPart, contentType);
            return childPart;
        }

        /// <summary>
        /// Adds a EmbeddedControlPersistencePart to the GlossaryDocumentPart
        /// </summary>
        /// <param name="contentType">The content type of the EmbeddedControlPersistencePart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(string contentType, string id)
        {
            var childPart = new EmbeddedControlPersistencePart();
            InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds a EmbeddedControlPersistencePart to the GlossaryDocumentPart
        /// </summary>
        /// <param name="partType">The part type of the EmbeddedControlPersistencePart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(EmbeddedControlPersistencePartType partType, string id)
        {
            var contentType = EmbeddedControlPersistencePartTypeInfo.GetContentType(partType);
            var partExtension = EmbeddedControlPersistencePartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddEmbeddedControlPersistencePart(contentType, id);
        }

        /// <summary>
        /// Adds a EmbeddedControlPersistencePart to the GlossaryDocumentPart
        /// </summary>
        /// <param name="partType">The part type of the EmbeddedControlPersistencePart</param>
        /// <return>The newly added part</return>
        public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(EmbeddedControlPersistencePartType partType)
        {
            var contentType = EmbeddedControlPersistencePartTypeInfo.GetContentType(partType);
            var partExtension = EmbeddedControlPersistencePartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddEmbeddedControlPersistencePart(contentType);
        }

        /// <summary>
        /// Adds a EmbeddedObjectPart to the GlossaryDocumentPart
        /// </summary>
        /// <param name="contentType">The content type of the EmbeddedObjectPart</param>
        /// <return>The newly added part</return>
        public EmbeddedObjectPart AddEmbeddedObjectPart(string contentType)
        {
            var childPart = new EmbeddedObjectPart();
            InitPart(childPart, contentType);
            return childPart;
        }

        /// <summary>
        /// Adds a EmbeddedPackagePart to the GlossaryDocumentPart
        /// </summary>
        /// <param name="contentType">The content type of the EmbeddedPackagePart</param>
        /// <return>The newly added part</return>
        public EmbeddedPackagePart AddEmbeddedPackagePart(string contentType)
        {
            var childPart = new EmbeddedPackagePart();
            InitPart(childPart, contentType);
            return childPart;
        }

        /// <summary>
        /// Adds a ImagePart to the GlossaryDocumentPart
        /// </summary>
        /// <param name="contentType">The content type of the ImagePart</param>
        /// <return>The newly added part</return>
        public ImagePart AddImagePart(string contentType)
        {
            var childPart = new ImagePart();
            InitPart(childPart, contentType);
            return childPart;
        }

        /// <summary>
        /// Adds a ImagePart to the GlossaryDocumentPart
        /// </summary>
        /// <param name="contentType">The content type of the ImagePart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public ImagePart AddImagePart(string contentType, string id)
        {
            var childPart = new ImagePart();
            InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds a ImagePart to the GlossaryDocumentPart
        /// </summary>
        /// <param name="partType">The part type of the ImagePart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public ImagePart AddImagePart(ImagePartType partType, string id)
        {
            var contentType = ImagePartTypeInfo.GetContentType(partType);
            var partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddImagePart(contentType, id);
        }

        /// <summary>
        /// Adds a ImagePart to the GlossaryDocumentPart
        /// </summary>
        /// <param name="partType">The part type of the ImagePart</param>
        /// <return>The newly added part</return>
        public ImagePart AddImagePart(ImagePartType partType)
        {
            var contentType = ImagePartTypeInfo.GetContentType(partType);
            var partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddImagePart(contentType);
        }

        /// <summary>
        /// Adds a VideoReferenceRelationship to the GlossaryDocumentPart
        /// </summary>
        /// <param name="mediaDataPart">The part type of the VideoReferenceRelationship</param>
        /// <return>The newly added part</return>
        public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart)
        {return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart);
        }

        /// <summary>
        /// Adds a VideoReferenceRelationship to the GlossaryDocumentPart
        /// </summary>
        /// <param name="mediaDataPart">The part type of the VideoReferenceRelationship</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart, string id)
        {return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart, id);
        }

        /// <inheritdoc/>
        internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
        {
            ThrowIfObjectDisposed();
            if (relationshipType is null)
            {
                throw new ArgumentNullException(nameof(relationshipType));
            }

            switch (relationshipType)
            {
                case WordprocessingCommentsPart.RelationshipTypeConstant:
                    return new WordprocessingCommentsPart();
                case DocumentSettingsPart.RelationshipTypeConstant:
                    return new DocumentSettingsPart();
                case EndnotesPart.RelationshipTypeConstant:
                    return new EndnotesPart();
                case FontTablePart.RelationshipTypeConstant:
                    return new FontTablePart();
                case FootnotesPart.RelationshipTypeConstant:
                    return new FootnotesPart();
                case NumberingDefinitionsPart.RelationshipTypeConstant:
                    return new NumberingDefinitionsPart();
                case StyleDefinitionsPart.RelationshipTypeConstant:
                    return new StyleDefinitionsPart();
                case StylesWithEffectsPart.RelationshipTypeConstant:
                    return new StylesWithEffectsPart();
                case WebSettingsPart.RelationshipTypeConstant:
                    return new WebSettingsPart();
                case FooterPart.RelationshipTypeConstant:
                    return new FooterPart();
                case HeaderPart.RelationshipTypeConstant:
                    return new HeaderPart();
                case WordprocessingPrinterSettingsPart.RelationshipTypeConstant:
                    return new WordprocessingPrinterSettingsPart();
                case CustomizationPart.RelationshipTypeConstant:
                    return new CustomizationPart();
                case VbaProjectPart.RelationshipTypeConstant:
                    return new VbaProjectPart();
                case WordprocessingCommentsExPart.RelationshipTypeConstant:
                    return new WordprocessingCommentsExPart();
                case WordprocessingPeoplePart.RelationshipTypeConstant:
                    return new WordprocessingPeoplePart();
                case AlternativeFormatImportPart.RelationshipTypeConstant:
                    return new AlternativeFormatImportPart();
                case ChartPart.RelationshipTypeConstant:
                    return new ChartPart();
                case DiagramColorsPart.RelationshipTypeConstant:
                    return new DiagramColorsPart();
                case DiagramDataPart.RelationshipTypeConstant:
                    return new DiagramDataPart();
                case DiagramPersistLayoutPart.RelationshipTypeConstant:
                    return new DiagramPersistLayoutPart();
                case DiagramLayoutDefinitionPart.RelationshipTypeConstant:
                    return new DiagramLayoutDefinitionPart();
                case DiagramStylePart.RelationshipTypeConstant:
                    return new DiagramStylePart();
                case EmbeddedControlPersistencePart.RelationshipTypeConstant:
                    return new EmbeddedControlPersistencePart();
                case EmbeddedObjectPart.RelationshipTypeConstant:
                    return new EmbeddedObjectPart();
                case EmbeddedPackagePart.RelationshipTypeConstant:
                    return new EmbeddedPackagePart();
                case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
            }

            throw new ArgumentOutOfRangeException(nameof(relationshipType));
        }
    }
}
