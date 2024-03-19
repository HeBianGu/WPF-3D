using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkWordCloud
	/// </summary>
	/// <remarks>
	///    generate a word cloud visualization of a text document
	///
	/// Word Clouds, AKA Tag Clouds
	/// (https://en.wikipedia.org/wiki/Tag_cloud), are a text visualization
	/// technique that displays individual words with properties that
	/// depend on the frequency of a word in a document. vtkWordCloud
	/// varies the font size based on word frequency. Word Clouds are useful
	/// for quickly perceiving the most prominent terms in a document.
	/// Also, Word Clouds can identify trends and patterns that would
	/// otherwise be unclear or difficult to see in a tabular
	/// format. Frequently used keywords stand out better in a word
	/// cloud. Common words that might be overlooked in tabular form are
	/// highlighted in the larger text, making them pop out when displayed
	/// in a word cloud.
	///
	/// There is some controversy about the usefulness of word
	/// clouds. Their best use may be for presentations, see
	/// https://tinyurl.com/y59hy7oa
	///
	/// The generation of the word cloud proceeds as follows:
	/// 1. Read the text file
	/// 2. Split text into words to be processed
	///    Extract words from the text
	///    Drop the case of each word for filtering
	///    Filter the words
	///      Replace words from the ReplacementPairs list
	///      Skip the word if it is in the stop list or contains a digit
	///      Skip single character words
	///    Raise the case of the first letter in each word
	///    Sort the word list by frequency
	/// 3. Create a rectangular mask image or read a mask image
	/// 4. For each word
	///    Render the word into an image
	///    Try to add the word to the word cloud image.
	///      For each orientation, see if the word "fits"
	///        If no fit, move along a path to try another location
	///
	/// NOTE: A word fits if all of the non-zero word cloud pixels in the
	/// extent of the text image are background pixels.
	///
	/// NOTE: The path is an Archimedean Spiral
	/// (https://en.wikipedia.org/wiki/Archimedean_spiral)
	///
	/// NOTE: vtkWordCloud has a built-in list of stop word. Stop words are
	/// words that are filtered out before processing of the text, such as
	/// the, is, at, which, and so on.
	///
	/// NOTE: Color names are defined in vtkNamedColors. A visual
	/// representation of color names is here: https://tinyurl.com/y3yxcxj6
	///
	/// NOTE: vtkWordCloud offers Several methods to customize the resulting
	/// visualization. The class provides defaults that provide a reasonable
	/// result.
	///
	/// BackgroundColorName - The vtkNamedColors name for the background
	/// (MidNightBlue). See https://tinyurl.com/y3yxcxj6 for a visual
	/// representation of the named colors.
	///
	/// ColorDistribution - Distribution of random colors(.6 1.0), if
	/// WordColorName is empty.
	///
	/// ColorSchemeName - Name of a color scheme from vtkColorSeries to be
	/// used to select colors for the words (), if WordColorName is empty.
	/// See https://tinyurl.com/y3j6c27o for a visual representation of the
	/// color schemes.
	///
	/// DPI - Dots per inch(200) of the rendered text. DPI is used as a
	/// scaling mechanism for the words. As DPI increases, the word size
	/// increases. If there are too, few skipped words, increase this value,
	/// too many, decrease it.
	///
	/// FontFileName - If empty, the built-in Arial font is used(). The
	/// FontFileName is the name of a file that contains a TrueType font.
	/// https://www.1001freefonts.com/ is a good source for free TrueType
	/// fonts.
	///
	/// FontMultiplier - Font multiplier(6). The final FontSize is this value
	/// times the word frequency.
	///
	/// Gap - Space gap of words (2). The gap is the number of spaces added to
	/// the beginning and end of each word.
	///
	/// MaskColorName - Name of the color for the mask (black). This is the
	/// name of the vtknamedColors that defines the foreground of the
	/// mask. Usually black or white.  See https://tinyurl.com/y3yxcxj6 for
	/// a visual representation of the named colors.
	///
	/// MaskFileName - Mask file name(). If a mask file is specified, it will be
	/// used as the mask. Otherwise, a black square is used as the mask. The
	/// mask file should contain three channels of unsigned char values. If
	/// the mask file is just a single unsigned char, specify turn the boolean
	/// BWMask on.  If BWmask is on, the class will create a three channel
	/// image using vtkImageAppendComponents.
	///
	/// BWMask - Mask image has a single channel(false). Mask images typically
	/// have three channels (r,g,b).
	///
	/// MaxFontSize - Maximum font size(48).
	///
	/// MinFontSize - Minimum font size(8).
	///
	/// MinFrequency - Minimum word frequency accepted(2). Word with
	/// frequencies less than this will be ignored.
	///
	/// OffsetDistribution - Range of uniform random offsets(-size[0]/100.0
	/// -size{1]/100.0)(-20 20). These offsets are offsets from the generated
	/// path for word layout.
	///
	/// OrientationDistribution - Ranges of random orientations(-20 20). If
	/// discrete orientations are not defined, these orientations will be
	/// generated.
	///
	/// Orientations - Vector of discrete orientations(). If non-empty,
	/// these will be used instead of the orientations distribution");
	///
	/// ReplacementPairs - Replace the first word with another second word
	/// ().  The each word will also added to the StopList. The second
	/// argument can contain multiple words. For example you could replace
	/// "bill" with "Bill Lorensen" or, "vtk" with "VTK . Remember that
	/// words are always stored internally with lower case, even though the
	/// first letter is capitalized in the Word Cloud.
	///
	/// Sizes - Size of image(640 480).
	///
	/// StopWords - User provided stop words(). Stop words are words that
	/// are filtered out before processing of the text, such as the, is,
	/// at, which, and so on.  vtkWordClass has built-in stop words. The
	/// user-provided stop words are added to the built-in list. See
	/// https://en.wikipedia.org/wiki/Stop_words for a description.  The
	/// built-in stop words were derived from the english stop words at
	/// https://www.ranks.nl/stopwords. Stop words for other languages are
	/// also available.
	///
	/// StopListFileName - the name of a file that contains stop words,
	/// one word per line (). If present, the stop words in the file
	/// replace the built-in stop list.
	///
	/// Title - Add this word to the document's words and set a high
	/// frequency, so that is will be rendered first.
	///
	/// WordColorName - Name of the color for the words(). The name is
	/// selected from vtkNamedColors. If the name is empty, the
	/// ColorDistribution will generate random colors.  See
	/// https://tinyurl.com/y3yxcxj6 for a visual representation of the
	/// named colors.
	///
	/// The class also provided Get methods that return vectors
	/// StopWords, SkippedWords and KeptWords.
	/// </remarks>
	// Token: 0x020006A1 RID: 1697
	public class vtkWordCloud : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012253 RID: 74323 RVA: 0x00196A53 File Offset: 0x00194C53
		static vtkWordCloud()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWordCloud.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWordCloud"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012254 RID: 74324 RVA: 0x00196A7B File Offset: 0x00194C7B
		public vtkWordCloud(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012255 RID: 74325
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWordCloud_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with vertex cell generation turned off.
		/// </summary>
		// Token: 0x06012256 RID: 74326 RVA: 0x00196A8C File Offset: 0x00194C8C
		public new static vtkWordCloud New()
		{
			vtkWordCloud result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWordCloud.vtkWordCloud_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWordCloud)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with vertex cell generation turned off.
		/// </summary>
		// Token: 0x06012257 RID: 74327 RVA: 0x00196AE0 File Offset: 0x00194CE0
		public vtkWordCloud() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkWordCloud.vtkWordCloud_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012258 RID: 74328 RVA: 0x00196B24 File Offset: 0x00194D24
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012259 RID: 74329
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWordCloud_AddOrientation_01(HandleRef pThis, double arg);

		/// <summary>
		/// Set/Add/Get Orientations, a vector of discrete orientations (). If
		/// non-empty, these will be used instead of the orientations
		/// distribution").
		/// </summary>
		// Token: 0x0601225A RID: 74330 RVA: 0x00196B2F File Offset: 0x00194D2F
		public void AddOrientation(double arg)
		{
			vtkWordCloud.vtkWordCloud_AddOrientation_01(base.GetCppThis(), arg);
		}

		// Token: 0x0601225B RID: 74331
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWordCloud_AddStopWord_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string word);

		/// <summary>
		/// Set/Add/Get StopWords, a set of user provided stop
		/// words(). vtkWordClass has built-in stop words. The user-provided
		/// stop words are added to the built-in list.
		/// </summary>
		// Token: 0x0601225C RID: 74332 RVA: 0x00196B3F File Offset: 0x00194D3F
		public void AddStopWord(string word)
		{
			vtkWordCloud.vtkWordCloud_AddStopWord_02(base.GetCppThis(), word);
		}

		// Token: 0x0601225D RID: 74333
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWordCloud_ClearStopWords_03(HandleRef pThis);

		/// <summary>
		/// Set/Add/Get StopWords, a set of user provided stop
		/// words(). vtkWordClass has built-in stop words. The user-provided
		/// stop words are added to the built-in list.
		/// </summary>
		// Token: 0x0601225E RID: 74334 RVA: 0x00196B4F File Offset: 0x00194D4F
		public void ClearStopWords()
		{
			vtkWordCloud.vtkWordCloud_ClearStopWords_03(base.GetCppThis());
		}

		// Token: 0x0601225F RID: 74335
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkWordCloud_GetBWMask_04(HandleRef pThis);

		/// <summary>
		/// Set/Get boolean that indicates the mask image is a single
		/// channel(false).
		/// </summary>
		// Token: 0x06012260 RID: 74336 RVA: 0x00196B60 File Offset: 0x00194D60
		public virtual bool GetBWMask()
		{
			return vtkWordCloud.vtkWordCloud_GetBWMask_04(base.GetCppThis()) != 0;
		}

		// Token: 0x06012261 RID: 74337
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkWordCloud_GetBackgroundColorName_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the vtkNamedColors name for the background(MidNightBlue).
		/// </summary>
		// Token: 0x06012262 RID: 74338 RVA: 0x00196B88 File Offset: 0x00194D88
		public virtual string GetBackgroundColorName()
		{
			return vtkWordCloud.vtkWordCloud_GetBackgroundColorName_05(base.GetCppThis());
		}

		// Token: 0x06012263 RID: 74339
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkWordCloud_GetColorSchemeName_06(HandleRef pThis);

		/// <summary>
		/// Set/Get ColorSchemeName, the name of a color scheme from
		/// vtkColorScheme to be used to select colors for the words (), if
		/// WordColorName is empty. See https://tinyurl.com/y3j6c27o for a
		/// visual representation of the color schemes.
		/// </summary>
		// Token: 0x06012264 RID: 74340 RVA: 0x00196BA8 File Offset: 0x00194DA8
		public virtual string GetColorSchemeName()
		{
			return vtkWordCloud.vtkWordCloud_GetColorSchemeName_06(base.GetCppThis());
		}

		// Token: 0x06012265 RID: 74341
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWordCloud_GetDPI_07(HandleRef pThis);

		/// <summary>
		/// Set/GetDPI - Dots per inch(200) of the rendered text. DPI is
		/// used as a scaling mechanism for the words. As DPI increases,
		/// the word size increases. If there are too, few skipped words,
		/// increase this value, too many, decrease it.
		/// </summary>
		// Token: 0x06012266 RID: 74342 RVA: 0x00196BC8 File Offset: 0x00194DC8
		public virtual int GetDPI()
		{
			return vtkWordCloud.vtkWordCloud_GetDPI_07(base.GetCppThis());
		}

		// Token: 0x06012267 RID: 74343
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkWordCloud_GetFileName_08(HandleRef pThis);

		/// <summary>
		/// Set/Get FileName, the name of the file that contains the text to
		/// be processed.
		/// </summary>
		// Token: 0x06012268 RID: 74344 RVA: 0x00196BE8 File Offset: 0x00194DE8
		public virtual string GetFileName()
		{
			return vtkWordCloud.vtkWordCloud_GetFileName_08(base.GetCppThis());
		}

		// Token: 0x06012269 RID: 74345
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkWordCloud_GetFontFileName_09(HandleRef pThis);

		/// <summary>
		/// Set/Get FontFileName, If empty, the built-in Arial font is
		/// used(). The FontFileName is the name of a file that contains a
		/// TrueType font.
		/// </summary>
		// Token: 0x0601226A RID: 74346 RVA: 0x00196C08 File Offset: 0x00194E08
		public virtual string GetFontFileName()
		{
			return vtkWordCloud.vtkWordCloud_GetFontFileName_09(base.GetCppThis());
		}

		// Token: 0x0601226B RID: 74347
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWordCloud_GetFontMultiplier_10(HandleRef pThis);

		/// <summary>
		/// Set/Get FontMultiplier, the font multiplier(6). The final
		/// FontSize is this value the word frequency.
		/// </summary>
		// Token: 0x0601226C RID: 74348 RVA: 0x00196C28 File Offset: 0x00194E28
		public virtual int GetFontMultiplier()
		{
			return vtkWordCloud.vtkWordCloud_GetFontMultiplier_10(base.GetCppThis());
		}

		// Token: 0x0601226D RID: 74349
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWordCloud_GetGap_11(HandleRef pThis);

		/// <summary>
		/// Set/Get Gap, the space gap of words (2). The gap is the number
		/// of spaces added to the beginning and end of each word.
		/// </summary>
		// Token: 0x0601226E RID: 74350 RVA: 0x00196C48 File Offset: 0x00194E48
		public virtual int GetGap()
		{
			return vtkWordCloud.vtkWordCloud_GetGap_11(base.GetCppThis());
		}

		// Token: 0x0601226F RID: 74351
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkWordCloud_GetMaskColorName_12(HandleRef pThis);

		/// <summary>
		/// Set/Get MaskColorName, the name of the color for the mask
		/// (black). This is the name of the vtkNamedColors that defines
		/// the foreground of the mask. Usually black or white.
		/// </summary>
		// Token: 0x06012270 RID: 74352 RVA: 0x00196C68 File Offset: 0x00194E68
		public virtual string GetMaskColorName()
		{
			return vtkWordCloud.vtkWordCloud_GetMaskColorName_12(base.GetCppThis());
		}

		// Token: 0x06012271 RID: 74353
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkWordCloud_GetMaskFileName_13(HandleRef pThis);

		/// <summary>
		/// Set/Get MaskFileName, the mask file name(). If a mask file is
		/// specified, it will be used as the mask. Otherwise, a black
		/// square is used as the mask. The mask file should contain three
		/// channels of unsigned char values. If the mask file is just a
		/// single unsigned char, specify turn the boolean BWMask on.  If
		/// BWmask is on, the class will create a three channel image using
		/// vtkImageAppendComponents.
		/// </summary>
		// Token: 0x06012272 RID: 74354 RVA: 0x00196C88 File Offset: 0x00194E88
		public virtual string GetMaskFileName()
		{
			return vtkWordCloud.vtkWordCloud_GetMaskFileName_13(base.GetCppThis());
		}

		// Token: 0x06012273 RID: 74355
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWordCloud_GetMaxFontSize_14(HandleRef pThis);

		/// <summary>
		/// Set/Get MaxFontSize, the maximum font size(48).
		/// </summary>
		// Token: 0x06012274 RID: 74356 RVA: 0x00196CA8 File Offset: 0x00194EA8
		public virtual int GetMaxFontSize()
		{
			return vtkWordCloud.vtkWordCloud_GetMaxFontSize_14(base.GetCppThis());
		}

		// Token: 0x06012275 RID: 74357
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWordCloud_GetMinFontSize_15(HandleRef pThis);

		/// <summary>
		/// Set/Get MinFontSize, the minimum font size(8).
		/// </summary>
		// Token: 0x06012276 RID: 74358 RVA: 0x00196CC8 File Offset: 0x00194EC8
		public virtual int GetMinFontSize()
		{
			return vtkWordCloud.vtkWordCloud_GetMinFontSize_15(base.GetCppThis());
		}

		// Token: 0x06012277 RID: 74359
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWordCloud_GetMinFrequency_16(HandleRef pThis);

		/// <summary>
		/// Set/Get MinFrequency, the minimum word frequency
		/// accepted(2). Words with frequencies less than this will be
		/// ignored.
		/// </summary>
		// Token: 0x06012278 RID: 74360 RVA: 0x00196CE8 File Offset: 0x00194EE8
		public virtual int GetMinFrequency()
		{
			return vtkWordCloud.vtkWordCloud_GetMinFrequency_16(base.GetCppThis());
		}

		// Token: 0x06012279 RID: 74361
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWordCloud_GetNumberOfGenerationsFromBase_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601227A RID: 74362 RVA: 0x00196D08 File Offset: 0x00194F08
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkWordCloud.vtkWordCloud_GetNumberOfGenerationsFromBase_17(base.GetCppThis(), type);
		}

		// Token: 0x0601227B RID: 74363
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWordCloud_GetNumberOfGenerationsFromBaseType_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601227C RID: 74364 RVA: 0x00196D28 File Offset: 0x00194F28
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkWordCloud.vtkWordCloud_GetNumberOfGenerationsFromBaseType_18(type);
		}

		// Token: 0x0601227D RID: 74365
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkWordCloud_GetStopListFileName_19(HandleRef pThis);

		/// <summary>
		/// Set/Get StopListFileName, the name of the file that contains the
		/// stop words, one per line.
		/// </summary>
		// Token: 0x0601227E RID: 74366 RVA: 0x00196D44 File Offset: 0x00194F44
		public virtual string GetStopListFileName()
		{
			return vtkWordCloud.vtkWordCloud_GetStopListFileName_19(base.GetCppThis());
		}

		// Token: 0x0601227F RID: 74367
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkWordCloud_GetTitle_20(HandleRef pThis);

		/// <summary>
		/// Set/Get Title, add this word to the document's words and set a
		/// high frequency, so that is will be rendered first.
		/// </summary>
		// Token: 0x06012280 RID: 74368 RVA: 0x00196D64 File Offset: 0x00194F64
		public virtual string GetTitle()
		{
			return vtkWordCloud.vtkWordCloud_GetTitle_20(base.GetCppThis());
		}

		// Token: 0x06012281 RID: 74369
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkWordCloud_GetWordColorName_21(HandleRef pThis);

		/// <summary>
		/// Set/Get WordColorName, the name of the color for the
		/// words(). The name is selected from vtkNamedColors. If the name
		/// is empty, the ColorDistribution will generate random colors.
		/// </summary>
		// Token: 0x06012282 RID: 74370 RVA: 0x00196D84 File Offset: 0x00194F84
		public virtual string GetWordColorName()
		{
			return vtkWordCloud.vtkWordCloud_GetWordColorName_21(base.GetCppThis());
		}

		// Token: 0x06012283 RID: 74371
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWordCloud_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012284 RID: 74372 RVA: 0x00196DA4 File Offset: 0x00194FA4
		public override int IsA(string type)
		{
			return vtkWordCloud.vtkWordCloud_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x06012285 RID: 74373
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWordCloud_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012286 RID: 74374 RVA: 0x00196DC4 File Offset: 0x00194FC4
		public new static int IsTypeOf(string type)
		{
			return vtkWordCloud.vtkWordCloud_IsTypeOf_23(type);
		}

		// Token: 0x06012287 RID: 74375
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWordCloud_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012288 RID: 74376 RVA: 0x00196DE0 File Offset: 0x00194FE0
		public new vtkWordCloud NewInstance()
		{
			vtkWordCloud result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWordCloud.vtkWordCloud_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWordCloud)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012289 RID: 74377
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWordCloud_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601228A RID: 74378 RVA: 0x00196E3C File Offset: 0x0019503C
		public new static vtkWordCloud SafeDownCast(vtkObjectBase o)
		{
			vtkWordCloud vtkWordCloud = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWordCloud.vtkWordCloud_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWordCloud = (vtkWordCloud)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWordCloud.Register(null);
				}
			}
			return vtkWordCloud;
		}

		// Token: 0x0601228B RID: 74379
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWordCloud_SetBWMask_27(HandleRef pThis, byte arg);

		/// <summary>
		/// Set/Get boolean that indicates the mask image is a single
		/// channel(false).
		/// </summary>
		// Token: 0x0601228C RID: 74380 RVA: 0x00196EBB File Offset: 0x001950BB
		public virtual void SetBWMask(bool arg)
		{
			vtkWordCloud.vtkWordCloud_SetBWMask_27(base.GetCppThis(), arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601228D RID: 74381
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWordCloud_SetBackgroundColorName_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg);

		/// <summary>
		/// Set/Get the vtkNamedColors name for the background(MidNightBlue).
		/// </summary>
		// Token: 0x0601228E RID: 74382 RVA: 0x00196ED3 File Offset: 0x001950D3
		public virtual void SetBackgroundColorName(string arg)
		{
			vtkWordCloud.vtkWordCloud_SetBackgroundColorName_28(base.GetCppThis(), arg);
		}

		// Token: 0x0601228F RID: 74383
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWordCloud_SetColorSchemeName_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg);

		/// <summary>
		/// Set/Get ColorSchemeName, the name of a color scheme from
		/// vtkColorScheme to be used to select colors for the words (), if
		/// WordColorName is empty. See https://tinyurl.com/y3j6c27o for a
		/// visual representation of the color schemes.
		/// </summary>
		// Token: 0x06012290 RID: 74384 RVA: 0x00196EE3 File Offset: 0x001950E3
		public virtual void SetColorSchemeName(string arg)
		{
			vtkWordCloud.vtkWordCloud_SetColorSchemeName_29(base.GetCppThis(), arg);
		}

		// Token: 0x06012291 RID: 74385
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWordCloud_SetDPI_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/GetDPI - Dots per inch(200) of the rendered text. DPI is
		/// used as a scaling mechanism for the words. As DPI increases,
		/// the word size increases. If there are too, few skipped words,
		/// increase this value, too many, decrease it.
		/// </summary>
		// Token: 0x06012292 RID: 74386 RVA: 0x00196EF3 File Offset: 0x001950F3
		public virtual void SetDPI(int _arg)
		{
			vtkWordCloud.vtkWordCloud_SetDPI_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06012293 RID: 74387
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWordCloud_SetFileName_31(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg);

		/// <summary>
		/// Set/Get FileName, the name of the file that contains the text to
		/// be processed.
		/// </summary>
		// Token: 0x06012294 RID: 74388 RVA: 0x00196F03 File Offset: 0x00195103
		public virtual void SetFileName(string arg)
		{
			vtkWordCloud.vtkWordCloud_SetFileName_31(base.GetCppThis(), arg);
		}

		// Token: 0x06012295 RID: 74389
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWordCloud_SetFontFileName_32(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg);

		/// <summary>
		/// Set/Get FontFileName, If empty, the built-in Arial font is
		/// used(). The FontFileName is the name of a file that contains a
		/// TrueType font.
		/// </summary>
		// Token: 0x06012296 RID: 74390 RVA: 0x00196F13 File Offset: 0x00195113
		public virtual void SetFontFileName(string arg)
		{
			vtkWordCloud.vtkWordCloud_SetFontFileName_32(base.GetCppThis(), arg);
		}

		// Token: 0x06012297 RID: 74391
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWordCloud_SetFontMultiplier_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get FontMultiplier, the font multiplier(6). The final
		/// FontSize is this value the word frequency.
		/// </summary>
		// Token: 0x06012298 RID: 74392 RVA: 0x00196F23 File Offset: 0x00195123
		public virtual void SetFontMultiplier(int _arg)
		{
			vtkWordCloud.vtkWordCloud_SetFontMultiplier_33(base.GetCppThis(), _arg);
		}

		// Token: 0x06012299 RID: 74393
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWordCloud_SetGap_34(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get Gap, the space gap of words (2). The gap is the number
		/// of spaces added to the beginning and end of each word.
		/// </summary>
		// Token: 0x0601229A RID: 74394 RVA: 0x00196F33 File Offset: 0x00195133
		public virtual void SetGap(int _arg)
		{
			vtkWordCloud.vtkWordCloud_SetGap_34(base.GetCppThis(), _arg);
		}

		// Token: 0x0601229B RID: 74395
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWordCloud_SetMaskColorName_35(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg);

		/// <summary>
		/// Set/Get MaskColorName, the name of the color for the mask
		/// (black). This is the name of the vtkNamedColors that defines
		/// the foreground of the mask. Usually black or white.
		/// </summary>
		// Token: 0x0601229C RID: 74396 RVA: 0x00196F43 File Offset: 0x00195143
		public virtual void SetMaskColorName(string arg)
		{
			vtkWordCloud.vtkWordCloud_SetMaskColorName_35(base.GetCppThis(), arg);
		}

		// Token: 0x0601229D RID: 74397
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWordCloud_SetMaskFileName_36(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg);

		/// <summary>
		/// Set/Get MaskFileName, the mask file name(). If a mask file is
		/// specified, it will be used as the mask. Otherwise, a black
		/// square is used as the mask. The mask file should contain three
		/// channels of unsigned char values. If the mask file is just a
		/// single unsigned char, specify turn the boolean BWMask on.  If
		/// BWmask is on, the class will create a three channel image using
		/// vtkImageAppendComponents.
		/// </summary>
		// Token: 0x0601229E RID: 74398 RVA: 0x00196F53 File Offset: 0x00195153
		public virtual void SetMaskFileName(string arg)
		{
			vtkWordCloud.vtkWordCloud_SetMaskFileName_36(base.GetCppThis(), arg);
		}

		// Token: 0x0601229F RID: 74399
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWordCloud_SetMaxFontSize_37(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get MaxFontSize, the maximum font size(48).
		/// </summary>
		// Token: 0x060122A0 RID: 74400 RVA: 0x00196F63 File Offset: 0x00195163
		public virtual void SetMaxFontSize(int _arg)
		{
			vtkWordCloud.vtkWordCloud_SetMaxFontSize_37(base.GetCppThis(), _arg);
		}

		// Token: 0x060122A1 RID: 74401
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWordCloud_SetMinFontSize_38(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get MinFontSize, the minimum font size(8).
		/// </summary>
		// Token: 0x060122A2 RID: 74402 RVA: 0x00196F73 File Offset: 0x00195173
		public virtual void SetMinFontSize(int _arg)
		{
			vtkWordCloud.vtkWordCloud_SetMinFontSize_38(base.GetCppThis(), _arg);
		}

		// Token: 0x060122A3 RID: 74403
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWordCloud_SetMinFrequency_39(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get MinFrequency, the minimum word frequency
		/// accepted(2). Words with frequencies less than this will be
		/// ignored.
		/// </summary>
		// Token: 0x060122A4 RID: 74404 RVA: 0x00196F83 File Offset: 0x00195183
		public virtual void SetMinFrequency(int _arg)
		{
			vtkWordCloud.vtkWordCloud_SetMinFrequency_39(base.GetCppThis(), _arg);
		}

		// Token: 0x060122A5 RID: 74405
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWordCloud_SetStopListFileName_40(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg);

		/// <summary>
		/// Set/Get StopListFileName, the name of the file that contains the
		/// stop words, one per line.
		/// </summary>
		// Token: 0x060122A6 RID: 74406 RVA: 0x00196F93 File Offset: 0x00195193
		public virtual void SetStopListFileName(string arg)
		{
			vtkWordCloud.vtkWordCloud_SetStopListFileName_40(base.GetCppThis(), arg);
		}

		// Token: 0x060122A7 RID: 74407
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWordCloud_SetTitle_41(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg);

		/// <summary>
		/// Set/Get Title, add this word to the document's words and set a
		/// high frequency, so that is will be rendered first.
		/// </summary>
		// Token: 0x060122A8 RID: 74408 RVA: 0x00196FA3 File Offset: 0x001951A3
		public virtual void SetTitle(string arg)
		{
			vtkWordCloud.vtkWordCloud_SetTitle_41(base.GetCppThis(), arg);
		}

		// Token: 0x060122A9 RID: 74409
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWordCloud_SetWordColorName_42(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg);

		/// <summary>
		/// Set/Get WordColorName, the name of the color for the
		/// words(). The name is selected from vtkNamedColors. If the name
		/// is empty, the ColorDistribution will generate random colors.
		/// </summary>
		// Token: 0x060122AA RID: 74410 RVA: 0x00196FB3 File Offset: 0x001951B3
		public virtual void SetWordColorName(string arg)
		{
			vtkWordCloud.vtkWordCloud_SetWordColorName_42(base.GetCppThis(), arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014F0 RID: 5360
		public new const string MRFullTypeName = "Kitware.VTK.vtkWordCloud";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014F1 RID: 5361
		public new static readonly string MRClassNameKey = "class vtkWordCloud";
	}
}
