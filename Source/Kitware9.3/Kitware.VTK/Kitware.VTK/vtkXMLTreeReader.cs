using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLTreeReader
	/// </summary>
	/// <remarks>
	///    reads an XML file into a vtkTree
	///
	///
	/// vtkXMLTreeReader parses an XML file and uses the nesting structure of the
	/// XML tags to generate a tree.  Node attributes are assigned to node arrays,
	/// and the special arrays .tagname and .chardata contain the tag type and the
	/// text internal to the tag, respectively.  The arrays are of type
	/// vtkStringArray.  There is an array for each attribute type in the XML file,
	/// even if it appears in only one tag.  If an attribute is missing from a tag,
	/// its value is the empty string.
	///
	/// If MaskArrays is on (the default is off), the filter will additionally make bit
	/// arrays whose names are prepended with ".valid." which are 1 if the element
	/// contains that attribute, and 0 otherwise.
	///
	/// For example, the XML file containing the text:
	/// &lt;pre&gt;
	/// &amp;lt;node name="jeff" age="26"&amp;gt;
	///   this is text in jeff's node
	///   &amp;lt;node name="joe"&amp;gt;
	///     &amp;lt;node name="al" initials="amb" other="something"/&amp;gt;
	///     &amp;lt;node name="dave" age="30"/&amp;gt;
	///   &amp;lt;/node&amp;gt;
	///   &amp;lt;node name="lisa"&amp;gt;this is text in lisa's node&amp;lt;/node&amp;gt;
	///   &amp;lt;node name="darlene" age="29"/&amp;gt;
	/// &amp;lt;/node&amp;gt;
	/// &lt;/pre&gt;
	///
	/// would be parsed into a tree with the following node IDs and structure:
	///
	/// &lt;pre&gt;
	/// 0 (jeff) - children: 1 (joe), 4 (lisa), 5 (darlene)
	/// 1 (joe)  - children: 2 (al), 3 (dave)
	/// 2 (al)
	/// 3 (dave)
	/// 4 (lisa)
	/// 5 (darlene)
	/// &lt;/pre&gt;
	///
	/// and the node data arrays would be as follows:
	///
	/// &lt;pre&gt;
	/// name      initials  other     age       .tagname  .chardata
	/// ------------------------------------------------------------------------------------------------
	/// jeff      (empty)   (empty)   26         node     "  this is text in jeff's node\n  \n  \n  \n"
	/// joe       (empty)   (empty)   (empty)    node     "\n    \n    \n  "
	/// al        amb       something (empty)    node     (empty)
	/// dave      (empty)   (empty)   30         node     (empty)
	/// lisa      (empty)   (empty)   (empty)    node     "this is text in lisa's node"
	/// darlene   (empty)   (empty)   29         node     (empty)
	/// &lt;/pre&gt;
	///
	/// There would also be the following bit arrays if MaskArrays is on:
	///
	/// &lt;pre&gt;
	/// .valid.name   .valid.initials   .valid.other   .valid.age
	/// ---------------------------------------------------------
	/// 1             0                 0              1
	/// 1             0                 0              0
	/// 1             1                 1              0
	/// 1             0                 0              1
	/// 1             0                 0              0
	/// 1             0                 0              1
	/// &lt;/pre&gt;
	/// </remarks>
	// Token: 0x020001AA RID: 426
	public class vtkXMLTreeReader : vtkTreeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600526C RID: 21100 RVA: 0x000783C0 File Offset: 0x000765C0
		static vtkXMLTreeReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLTreeReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLTreeReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600526D RID: 21101 RVA: 0x000783E8 File Offset: 0x000765E8
		public vtkXMLTreeReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600526E RID: 21102
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLTreeReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600526F RID: 21103 RVA: 0x000783F8 File Offset: 0x000765F8
		public new static vtkXMLTreeReader New()
		{
			vtkXMLTreeReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLTreeReader.vtkXMLTreeReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLTreeReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005270 RID: 21104 RVA: 0x0007844C File Offset: 0x0007664C
		public vtkXMLTreeReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLTreeReader.vtkXMLTreeReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005271 RID: 21105 RVA: 0x00078490 File Offset: 0x00076690
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005272 RID: 21106
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLTreeReader_GenerateEdgePedigreeIdsOff_01(HandleRef pThis);

		/// <summary>
		/// Set whether to use an property from the XML file as pedigree ids (off),
		/// or generate a new array with integer values starting at zero (on).
		/// Default is on.
		/// </summary>
		// Token: 0x06005273 RID: 21107 RVA: 0x0007849B File Offset: 0x0007669B
		public virtual void GenerateEdgePedigreeIdsOff()
		{
			vtkXMLTreeReader.vtkXMLTreeReader_GenerateEdgePedigreeIdsOff_01(base.GetCppThis());
		}

		// Token: 0x06005274 RID: 21108
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLTreeReader_GenerateEdgePedigreeIdsOn_02(HandleRef pThis);

		/// <summary>
		/// Set whether to use an property from the XML file as pedigree ids (off),
		/// or generate a new array with integer values starting at zero (on).
		/// Default is on.
		/// </summary>
		// Token: 0x06005275 RID: 21109 RVA: 0x000784AA File Offset: 0x000766AA
		public virtual void GenerateEdgePedigreeIdsOn()
		{
			vtkXMLTreeReader.vtkXMLTreeReader_GenerateEdgePedigreeIdsOn_02(base.GetCppThis());
		}

		// Token: 0x06005276 RID: 21110
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLTreeReader_GenerateVertexPedigreeIdsOff_03(HandleRef pThis);

		/// <summary>
		/// Set whether to use an property from the XML file as pedigree ids (off),
		/// or generate a new array with integer values starting at zero (on).
		/// Default is on.
		/// </summary>
		// Token: 0x06005277 RID: 21111 RVA: 0x000784B9 File Offset: 0x000766B9
		public virtual void GenerateVertexPedigreeIdsOff()
		{
			vtkXMLTreeReader.vtkXMLTreeReader_GenerateVertexPedigreeIdsOff_03(base.GetCppThis());
		}

		// Token: 0x06005278 RID: 21112
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLTreeReader_GenerateVertexPedigreeIdsOn_04(HandleRef pThis);

		/// <summary>
		/// Set whether to use an property from the XML file as pedigree ids (off),
		/// or generate a new array with integer values starting at zero (on).
		/// Default is on.
		/// </summary>
		// Token: 0x06005279 RID: 21113 RVA: 0x000784C8 File Offset: 0x000766C8
		public virtual void GenerateVertexPedigreeIdsOn()
		{
			vtkXMLTreeReader.vtkXMLTreeReader_GenerateVertexPedigreeIdsOn_04(base.GetCppThis());
		}

		// Token: 0x0600527A RID: 21114
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLTreeReader_GetEdgePedigreeIdArrayName_05(HandleRef pThis);

		/// <summary>
		/// The name of the edge pedigree ids. Default is "edge id".
		/// </summary>
		// Token: 0x0600527B RID: 21115 RVA: 0x000784D8 File Offset: 0x000766D8
		public virtual string GetEdgePedigreeIdArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLTreeReader.vtkXMLTreeReader_GetEdgePedigreeIdArrayName_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600527C RID: 21116
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLTreeReader_GetFileName_06(HandleRef pThis);

		/// <summary>
		/// If set, reads in the XML file specified.
		/// </summary>
		// Token: 0x0600527D RID: 21117 RVA: 0x00078514 File Offset: 0x00076714
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLTreeReader.vtkXMLTreeReader_GetFileName_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600527E RID: 21118
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkXMLTreeReader_GetGenerateEdgePedigreeIds_07(HandleRef pThis);

		/// <summary>
		/// Set whether to use an property from the XML file as pedigree ids (off),
		/// or generate a new array with integer values starting at zero (on).
		/// Default is on.
		/// </summary>
		// Token: 0x0600527F RID: 21119 RVA: 0x00078550 File Offset: 0x00076750
		public virtual bool GetGenerateEdgePedigreeIds()
		{
			return vtkXMLTreeReader.vtkXMLTreeReader_GetGenerateEdgePedigreeIds_07(base.GetCppThis()) != 0;
		}

		// Token: 0x06005280 RID: 21120
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkXMLTreeReader_GetGenerateVertexPedigreeIds_08(HandleRef pThis);

		/// <summary>
		/// Set whether to use an property from the XML file as pedigree ids (off),
		/// or generate a new array with integer values starting at zero (on).
		/// Default is on.
		/// </summary>
		// Token: 0x06005281 RID: 21121 RVA: 0x00078578 File Offset: 0x00076778
		public virtual bool GetGenerateVertexPedigreeIds()
		{
			return vtkXMLTreeReader.vtkXMLTreeReader_GetGenerateVertexPedigreeIds_08(base.GetCppThis()) != 0;
		}

		// Token: 0x06005282 RID: 21122
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkXMLTreeReader_GetMaskArrays_09(HandleRef pThis);

		/// <summary>
		/// If on, makes bit arrays for each attribute with name .valid.attribute_name
		/// for each attribute.  Default is off.
		/// </summary>
		// Token: 0x06005283 RID: 21123 RVA: 0x000785A0 File Offset: 0x000767A0
		public virtual bool GetMaskArrays()
		{
			return vtkXMLTreeReader.vtkXMLTreeReader_GetMaskArrays_09(base.GetCppThis()) != 0;
		}

		// Token: 0x06005284 RID: 21124
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLTreeReader_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005285 RID: 21125 RVA: 0x000785C8 File Offset: 0x000767C8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLTreeReader.vtkXMLTreeReader_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x06005286 RID: 21126
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLTreeReader_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005287 RID: 21127 RVA: 0x000785E8 File Offset: 0x000767E8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLTreeReader.vtkXMLTreeReader_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x06005288 RID: 21128
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkXMLTreeReader_GetReadCharData_12(HandleRef pThis);

		/// <summary>
		/// If on, stores the XML character data (i.e. textual data between tags)
		/// into an array named CharDataField, otherwise this field is skipped.
		/// Default is off.
		/// </summary>
		// Token: 0x06005289 RID: 21129 RVA: 0x00078604 File Offset: 0x00076804
		public virtual bool GetReadCharData()
		{
			return vtkXMLTreeReader.vtkXMLTreeReader_GetReadCharData_12(base.GetCppThis()) != 0;
		}

		// Token: 0x0600528A RID: 21130
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkXMLTreeReader_GetReadTagName_13(HandleRef pThis);

		/// <summary>
		/// If on, stores the XML tag name data in a field called .tagname
		/// otherwise this field is skipped.
		/// Default is on.
		/// </summary>
		// Token: 0x0600528B RID: 21131 RVA: 0x0007862C File Offset: 0x0007682C
		public virtual bool GetReadTagName()
		{
			return vtkXMLTreeReader.vtkXMLTreeReader_GetReadTagName_13(base.GetCppThis()) != 0;
		}

		// Token: 0x0600528C RID: 21132
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLTreeReader_GetVertexPedigreeIdArrayName_14(HandleRef pThis);

		/// <summary>
		/// The name of the vertex pedigree ids. Default is "vertex id".
		/// </summary>
		// Token: 0x0600528D RID: 21133 RVA: 0x00078654 File Offset: 0x00076854
		public virtual string GetVertexPedigreeIdArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLTreeReader.vtkXMLTreeReader_GetVertexPedigreeIdArrayName_14(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600528E RID: 21134
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLTreeReader_GetXMLString_15(HandleRef pThis);

		/// <summary>
		/// If set, and FileName is not set, reads in the XML string.
		/// </summary>
		// Token: 0x0600528F RID: 21135 RVA: 0x00078690 File Offset: 0x00076890
		public virtual string GetXMLString()
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLTreeReader.vtkXMLTreeReader_GetXMLString_15(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005290 RID: 21136
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLTreeReader_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005291 RID: 21137 RVA: 0x000786CC File Offset: 0x000768CC
		public override int IsA(string type)
		{
			return vtkXMLTreeReader.vtkXMLTreeReader_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x06005292 RID: 21138
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLTreeReader_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005293 RID: 21139 RVA: 0x000786EC File Offset: 0x000768EC
		public new static int IsTypeOf(string type)
		{
			return vtkXMLTreeReader.vtkXMLTreeReader_IsTypeOf_17(type);
		}

		// Token: 0x06005294 RID: 21140
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLTreeReader_MaskArraysOff_18(HandleRef pThis);

		/// <summary>
		/// If on, makes bit arrays for each attribute with name .valid.attribute_name
		/// for each attribute.  Default is off.
		/// </summary>
		// Token: 0x06005295 RID: 21141 RVA: 0x00078706 File Offset: 0x00076906
		public virtual void MaskArraysOff()
		{
			vtkXMLTreeReader.vtkXMLTreeReader_MaskArraysOff_18(base.GetCppThis());
		}

		// Token: 0x06005296 RID: 21142
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLTreeReader_MaskArraysOn_19(HandleRef pThis);

		/// <summary>
		/// If on, makes bit arrays for each attribute with name .valid.attribute_name
		/// for each attribute.  Default is off.
		/// </summary>
		// Token: 0x06005297 RID: 21143 RVA: 0x00078715 File Offset: 0x00076915
		public virtual void MaskArraysOn()
		{
			vtkXMLTreeReader.vtkXMLTreeReader_MaskArraysOn_19(base.GetCppThis());
		}

		// Token: 0x06005298 RID: 21144
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLTreeReader_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005299 RID: 21145 RVA: 0x00078724 File Offset: 0x00076924
		public new vtkXMLTreeReader NewInstance()
		{
			vtkXMLTreeReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLTreeReader.vtkXMLTreeReader_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLTreeReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600529A RID: 21146
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLTreeReader_ReadCharDataOff_22(HandleRef pThis);

		/// <summary>
		/// If on, stores the XML character data (i.e. textual data between tags)
		/// into an array named CharDataField, otherwise this field is skipped.
		/// Default is off.
		/// </summary>
		// Token: 0x0600529B RID: 21147 RVA: 0x0007877E File Offset: 0x0007697E
		public virtual void ReadCharDataOff()
		{
			vtkXMLTreeReader.vtkXMLTreeReader_ReadCharDataOff_22(base.GetCppThis());
		}

		// Token: 0x0600529C RID: 21148
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLTreeReader_ReadCharDataOn_23(HandleRef pThis);

		/// <summary>
		/// If on, stores the XML character data (i.e. textual data between tags)
		/// into an array named CharDataField, otherwise this field is skipped.
		/// Default is off.
		/// </summary>
		// Token: 0x0600529D RID: 21149 RVA: 0x0007878D File Offset: 0x0007698D
		public virtual void ReadCharDataOn()
		{
			vtkXMLTreeReader.vtkXMLTreeReader_ReadCharDataOn_23(base.GetCppThis());
		}

		// Token: 0x0600529E RID: 21150
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLTreeReader_ReadTagNameOff_24(HandleRef pThis);

		/// <summary>
		/// If on, stores the XML tag name data in a field called .tagname
		/// otherwise this field is skipped.
		/// Default is on.
		/// </summary>
		// Token: 0x0600529F RID: 21151 RVA: 0x0007879C File Offset: 0x0007699C
		public virtual void ReadTagNameOff()
		{
			vtkXMLTreeReader.vtkXMLTreeReader_ReadTagNameOff_24(base.GetCppThis());
		}

		// Token: 0x060052A0 RID: 21152
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLTreeReader_ReadTagNameOn_25(HandleRef pThis);

		/// <summary>
		/// If on, stores the XML tag name data in a field called .tagname
		/// otherwise this field is skipped.
		/// Default is on.
		/// </summary>
		// Token: 0x060052A1 RID: 21153 RVA: 0x000787AB File Offset: 0x000769AB
		public virtual void ReadTagNameOn()
		{
			vtkXMLTreeReader.vtkXMLTreeReader_ReadTagNameOn_25(base.GetCppThis());
		}

		// Token: 0x060052A2 RID: 21154
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLTreeReader_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060052A3 RID: 21155 RVA: 0x000787BC File Offset: 0x000769BC
		public new static vtkXMLTreeReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLTreeReader vtkXMLTreeReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLTreeReader.vtkXMLTreeReader_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLTreeReader = (vtkXMLTreeReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLTreeReader.Register(null);
				}
			}
			return vtkXMLTreeReader;
		}

		// Token: 0x060052A4 RID: 21156
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLTreeReader_SetEdgePedigreeIdArrayName_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The name of the edge pedigree ids. Default is "edge id".
		/// </summary>
		// Token: 0x060052A5 RID: 21157 RVA: 0x0007883B File Offset: 0x00076A3B
		public virtual void SetEdgePedigreeIdArrayName(string _arg)
		{
			vtkXMLTreeReader.vtkXMLTreeReader_SetEdgePedigreeIdArrayName_27(base.GetCppThis(), _arg);
		}

		// Token: 0x060052A6 RID: 21158
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLTreeReader_SetFileName_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// If set, reads in the XML file specified.
		/// </summary>
		// Token: 0x060052A7 RID: 21159 RVA: 0x0007884B File Offset: 0x00076A4B
		public virtual void SetFileName(string _arg)
		{
			vtkXMLTreeReader.vtkXMLTreeReader_SetFileName_28(base.GetCppThis(), _arg);
		}

		// Token: 0x060052A8 RID: 21160
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLTreeReader_SetGenerateEdgePedigreeIds_29(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set whether to use an property from the XML file as pedigree ids (off),
		/// or generate a new array with integer values starting at zero (on).
		/// Default is on.
		/// </summary>
		// Token: 0x060052A9 RID: 21161 RVA: 0x0007885B File Offset: 0x00076A5B
		public virtual void SetGenerateEdgePedigreeIds(bool _arg)
		{
			vtkXMLTreeReader.vtkXMLTreeReader_SetGenerateEdgePedigreeIds_29(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060052AA RID: 21162
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLTreeReader_SetGenerateVertexPedigreeIds_30(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set whether to use an property from the XML file as pedigree ids (off),
		/// or generate a new array with integer values starting at zero (on).
		/// Default is on.
		/// </summary>
		// Token: 0x060052AB RID: 21163 RVA: 0x00078873 File Offset: 0x00076A73
		public virtual void SetGenerateVertexPedigreeIds(bool _arg)
		{
			vtkXMLTreeReader.vtkXMLTreeReader_SetGenerateVertexPedigreeIds_30(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060052AC RID: 21164
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLTreeReader_SetMaskArrays_31(HandleRef pThis, byte _arg);

		/// <summary>
		/// If on, makes bit arrays for each attribute with name .valid.attribute_name
		/// for each attribute.  Default is off.
		/// </summary>
		// Token: 0x060052AD RID: 21165 RVA: 0x0007888B File Offset: 0x00076A8B
		public virtual void SetMaskArrays(bool _arg)
		{
			vtkXMLTreeReader.vtkXMLTreeReader_SetMaskArrays_31(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060052AE RID: 21166
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLTreeReader_SetReadCharData_32(HandleRef pThis, byte _arg);

		/// <summary>
		/// If on, stores the XML character data (i.e. textual data between tags)
		/// into an array named CharDataField, otherwise this field is skipped.
		/// Default is off.
		/// </summary>
		// Token: 0x060052AF RID: 21167 RVA: 0x000788A3 File Offset: 0x00076AA3
		public virtual void SetReadCharData(bool _arg)
		{
			vtkXMLTreeReader.vtkXMLTreeReader_SetReadCharData_32(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060052B0 RID: 21168
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLTreeReader_SetReadTagName_33(HandleRef pThis, byte _arg);

		/// <summary>
		/// If on, stores the XML tag name data in a field called .tagname
		/// otherwise this field is skipped.
		/// Default is on.
		/// </summary>
		// Token: 0x060052B1 RID: 21169 RVA: 0x000788BB File Offset: 0x00076ABB
		public virtual void SetReadTagName(bool _arg)
		{
			vtkXMLTreeReader.vtkXMLTreeReader_SetReadTagName_33(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060052B2 RID: 21170
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLTreeReader_SetVertexPedigreeIdArrayName_34(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The name of the vertex pedigree ids. Default is "vertex id".
		/// </summary>
		// Token: 0x060052B3 RID: 21171 RVA: 0x000788D3 File Offset: 0x00076AD3
		public virtual void SetVertexPedigreeIdArrayName(string _arg)
		{
			vtkXMLTreeReader.vtkXMLTreeReader_SetVertexPedigreeIdArrayName_34(base.GetCppThis(), _arg);
		}

		// Token: 0x060052B4 RID: 21172
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLTreeReader_SetXMLString_35(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// If set, and FileName is not set, reads in the XML string.
		/// </summary>
		// Token: 0x060052B5 RID: 21173 RVA: 0x000788E3 File Offset: 0x00076AE3
		public virtual void SetXMLString(string _arg)
		{
			vtkXMLTreeReader.vtkXMLTreeReader_SetXMLString_35(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007B9 RID: 1977
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLTreeReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007BA RID: 1978
		public new static readonly string MRClassNameKey = "class vtkXMLTreeReader";
	}
}
