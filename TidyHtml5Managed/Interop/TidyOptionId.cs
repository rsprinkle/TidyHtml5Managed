// Copyright (c) 2009 Mark Beaton
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.

using System;

namespace TidyManaged.Interop
{
	internal enum TidyOptionId
	{
        TidyUnknownOption,           /*< Unknown option! */

        TidyAccessibilityCheckLevel, /**< Accessibility check level */
        TidyAltText,                 /**< Default text for alt attribute */
        TidyAnchorAsName,            /**< Define anchors as name attributes */
        TidyAsciiChars,              /**< Convert quotes and dashes to nearest ASCII char */
        TidyBlockTags,               /**< Declared block tags */
        TidyBodyOnly,                /**< Output BODY content only */
        TidyBreakBeforeBR,           /**< Output newline before <br> or not? */
        TidyCharEncoding,            /**< In/out character encoding */
        TidyCoerceEndTags,           /**< Coerce end tags from start tags where probably intended */
        TidyCSSPrefix,               /**< CSS class naming for clean option */

        TidyCustomTags,              /**< Internal use ONLY */

        TidyDecorateInferredUL,      /**< Mark inferred UL elements with no indent CSS */
        TidyDoctype,                 /**< User specified doctype */

        TidyDoctypeMode,             /**< Internal use ONLY */

        TidyDropEmptyElems,          /**< Discard empty elements */
        TidyDropEmptyParas,          /**< Discard empty p elements */
        TidyDropPropAttrs,           /**< Discard proprietary attributes */
        TidyDuplicateAttrs,          /**< Keep first or last duplicate attribute */
        TidyEmacs,                   /**< If true, format error output for GNU Emacs */

        TidyEmacsFile,               /**< Internal use ONLY */

        TidyEmptyTags,               /**< Declared empty tags */
        TidyEncloseBlockText,        /**< If yes text in blocks is wrapped in P's */
        TidyEncloseBodyText,         /**< If yes text at body is wrapped in P's */
        TidyErrFile,                 /**< File name to write errors to */
        TidyEscapeCdata,             /**< Replace <![CDATA[]]> sections with escaped text */
        TidyEscapeScripts,           /**< Escape items that look like closing tags in script tags */
        TidyFixBackslash,            /**< Fix URLs by replacing \ with / */
        TidyFixComments,             /**< Fix comments with adjacent hyphens */
        TidyFixUri,                  /**< Applies URI encoding if necessary */
        TidyForceOutput,             /**< Output document even if errors were found */
        TidyGDocClean,               /**< Clean up HTML exported from Google Docs */
        TidyHideComments,            /**< Hides all (real) comments in output */
        TidyHtmlOut,                 /**< Output plain HTML, even for XHTML input.*/
        TidyInCharEncoding,          /**< Input character encoding (if different) */
        TidyIndentAttributes,        /**< Newline+indent before each attribute */
        TidyIndentCdata,             /**< Indent <!CDATA[ ... ]]> section */
        TidyIndentContent,           /**< Indent content of appropriate tags */
        TidyIndentSpaces,            /**< Indentation n spaces/tabs */
        TidyInlineTags,              /**< Declared inline tags */
        TidyJoinClasses,             /**< Join multiple class attributes */
        TidyJoinStyles,              /**< Join multiple style attributes */
        TidyKeepFileTimes,           /**< If yes last modied time is preserved */
        TidyKeepTabs,                /**< If yes keep input source tabs */
        TidyLiteralAttribs,          /**< If true attributes may use newlines */
        TidyLogicalEmphasis,         /**< Replace i by em and b by strong */
        TidyLowerLiterals,           /**< Folds known attribute values to lower case */
        TidyMakeBare,                /**< Replace smart quotes, em dashes, etc with ASCII */
        TidyMakeClean,               /**< Replace presentational clutter by style rules */
        TidyMark,                    /**< Add meta element indicating tidied doc */
        TidyMergeDivs,               /**< Merge multiple DIVs */
        TidyMergeEmphasis,           /**< Merge nested B and I elements */
        TidyMergeSpans,              /**< Merge multiple SPANs */
        TidyMetaCharset,             /**< Adds/checks/fixes meta charset in the head, based on document type */
        TidyMuteReports,             /**< Filter these messages from output. */
        TidyMuteShow,                /**< Show message ID's in the error table */
        TidyNCR,                     /**< Allow numeric character references */
        TidyNewline,                 /**< Output line ending (default to platform) */
        TidyNumEntities,             /**< Use numeric entities */
        TidyOmitOptionalTags,        /**< Suppress optional start tags and end tags */
        TidyOutCharEncoding,         /**< Output character encoding (if different) */
        TidyOutFile,                 /**< File name to write markup to */
        TidyOutputBOM,               /**< Output a Byte Order Mark (BOM) for UTF-16 encodings */
        TidyPPrintTabs,              /**< Indent using tabs instead of spaces */
        TidyPreserveEntities,        /**< Preserve entities */
        TidyPreTags,                 /**< Declared pre tags */
        TidyPriorityAttributes,      /**< Attributes to place first in an element */
        TidyPunctWrap,               /**< consider punctuation and breaking spaces for wrapping */
        TidyQuiet,                   /**< No 'Parsing X', guessed DTD or summary */
        TidyQuoteAmpersand,          /**< Output naked ampersand as &amp; */
        TidyQuoteMarks,              /**< Output " marks as &quot; */
        TidyQuoteNbsp,               /**< Output non-breaking space as entity */
        TidyReplaceColor,            /**< Replace hex color attribute values with names */
        TidyShowErrors,              /**< Number of errors to put out */
        TidyShowFilename,            /**< If true, the input filename is displayed with the error messages */
        TidyShowInfo,                /**< If true, info-level messages are shown */
        TidyShowMarkup,              /**< If false, normal output is suppressed */
        TidyShowMetaChange,          /**< show when meta http-equiv content charset was changed - compatibility */
        TidyShowWarnings,            /**< However errors are always shown */
        TidySkipNested,              /**< Skip nested tags in script and style CDATA */
        TidySortAttributes,          /**< Sort attributes */
        TidyStrictTagsAttr,          /**< Ensure tags and attributes match output HTML version */
        TidyStyleTags,               /**< Move style to head */
        TidyTabSize,                 /**< Expand tabs to n spaces */
        TidyUpperCaseAttrs,          /**< Output attributes in upper not lower case */
        TidyUpperCaseTags,           /**< Output tags in upper not lower case */
        TidyUseCustomTags,           /**< Enable Tidy to use autonomous custom tags */
        TidyVertSpace,               /**< degree to which markup is spread out vertically */
        TidyWarnPropAttrs,           /**< Warns on proprietary attributes */
        TidyWord2000,                /**< Draconian cleaning for Word2000 */
        TidyWrapAsp,                 /**< Wrap within ASP pseudo elements */
        TidyWrapAttVals,             /**< Wrap within attribute values */
        TidyWrapJste,                /**< Wrap within JSTE pseudo elements */
        TidyWrapLen,                 /**< Wrap margin */
        TidyWrapPhp,                 /**< Wrap consecutive PHP pseudo elements */
        TidyWrapScriptlets,          /**< Wrap within JavaScript string literals */
        TidyWrapSection,             /**< Wrap within <![ ... ]> section tags */
        TidyWriteBack,               /**< If true then output tidied markup */
        TidyXhtmlOut,                /**< Output extensible HTML */
        TidyXmlDecl,                 /**< Add <?xml?> for XML docs */
        TidyXmlOut,                  /**< Create output as XML */
        TidyXmlPIs,                  /**< If set to yes PIs must end with ?> */
        TidyXmlSpace,                /**< If set to yes adds xml:space attr as needed */
        TidyXmlTags,                 /**< Treat input as XML */
        N_TIDY_OPTIONS               /**< Must be last */
    }
}
