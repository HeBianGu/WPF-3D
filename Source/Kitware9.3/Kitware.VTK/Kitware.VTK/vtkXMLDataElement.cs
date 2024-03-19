using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLDataElement
	/// </summary>
	/// <remarks>
	///    Represents an XML element and those nested inside.
	///
	/// vtkXMLDataElement is used by vtkXMLDataParser to represent an XML
	/// element.  It provides methods to access the element's attributes
	/// and nested elements in a convenient manner.  This allows easy
	/// traversal of an input XML file by vtkXMLReader and its subclasses.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkXMLDataParser
	/// </seealso>
	// Token: 0x02000AE4 RID: 2788
	public class vtkXMLDataElement : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D6B6 RID: 120502 RVA: 0x00298B55 File Offset: 0x00296D55
		static vtkXMLDataElement()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLDataElement.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLDataElement"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D6B7 RID: 120503 RVA: 0x00298B7D File Offset: 0x00296D7D
		public vtkXMLDataElement(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D6B8 RID: 120504
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataElement_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D6B9 RID: 120505 RVA: 0x00298B8C File Offset: 0x00296D8C
		public new static vtkXMLDataElement New()
		{
			vtkXMLDataElement result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLDataElement.vtkXMLDataElement_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLDataElement)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D6BA RID: 120506 RVA: 0x00298BE0 File Offset: 0x00296DE0
		public vtkXMLDataElement() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLDataElement.vtkXMLDataElement_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D6BB RID: 120507 RVA: 0x00298C24 File Offset: 0x00296E24
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D6BC RID: 120508
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLDataElement_AddCharacterData_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string c, ulong length);

		/// <summary>
		/// Set/Get the character data between XML start/end tags.
		/// </summary>
		// Token: 0x0601D6BD RID: 120509 RVA: 0x00298C2F File Offset: 0x00296E2F
		public void AddCharacterData(string c, ulong length)
		{
			vtkXMLDataElement.vtkXMLDataElement_AddCharacterData_01(base.GetCppThis(), c, length);
		}

		// Token: 0x0601D6BE RID: 120510
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLDataElement_AddNestedElement_02(HandleRef pThis, HandleRef element);

		/// <summary>
		/// Add nested element
		/// </summary>
		// Token: 0x0601D6BF RID: 120511 RVA: 0x00298C40 File Offset: 0x00296E40
		public void AddNestedElement(vtkXMLDataElement element)
		{
			vtkXMLDataElement.vtkXMLDataElement_AddNestedElement_02(base.GetCppThis(), (element == null) ? default(HandleRef) : element.GetCppThis());
		}

		// Token: 0x0601D6C0 RID: 120512
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLDataElement_DeepCopy_03(HandleRef pThis, HandleRef elem);

		/// <summary>
		/// Copy this element from another of the same type (elem), recursively.
		/// Old attributes and nested elements are removed, new ones are created
		/// given the contents of 'elem'.
		/// Warning: Parent is ignored.
		/// </summary>
		// Token: 0x0601D6C1 RID: 120513 RVA: 0x00298C70 File Offset: 0x00296E70
		public virtual void DeepCopy(vtkXMLDataElement elem)
		{
			vtkXMLDataElement.vtkXMLDataElement_DeepCopy_03(base.GetCppThis(), (elem == null) ? default(HandleRef) : elem.GetCppThis());
		}

		// Token: 0x0601D6C2 RID: 120514
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataElement_FindNestedElement_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string id, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Find the first nested element with the given id, given name, or given
		/// name and id.
		/// WARNING: the search is only performed on the children, not
		/// the grand-children.
		/// </summary>
		// Token: 0x0601D6C3 RID: 120515 RVA: 0x00298CA0 File Offset: 0x00296EA0
		public vtkXMLDataElement FindNestedElement(string id)
		{
			vtkXMLDataElement vtkXMLDataElement = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLDataElement.vtkXMLDataElement_FindNestedElement_04(base.GetCppThis(), id, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataElement = (vtkXMLDataElement)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataElement.Register(null);
				}
			}
			return vtkXMLDataElement;
		}

		// Token: 0x0601D6C4 RID: 120516
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataElement_FindNestedElementWithName_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Find the first nested element with the given id, given name, or given
		/// name and id.
		/// WARNING: the search is only performed on the children, not
		/// the grand-children.
		/// </summary>
		// Token: 0x0601D6C5 RID: 120517 RVA: 0x00298D10 File Offset: 0x00296F10
		public vtkXMLDataElement FindNestedElementWithName(string name)
		{
			vtkXMLDataElement vtkXMLDataElement = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLDataElement.vtkXMLDataElement_FindNestedElementWithName_05(base.GetCppThis(), name, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataElement = (vtkXMLDataElement)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataElement.Register(null);
				}
			}
			return vtkXMLDataElement;
		}

		// Token: 0x0601D6C6 RID: 120518
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataElement_FindNestedElementWithNameAndAttribute_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string att_name, [MarshalAs(UnmanagedType.LPUTF8Str)] string att_value, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Find the first nested element with the given id, given name, or given
		/// name and id.
		/// WARNING: the search is only performed on the children, not
		/// the grand-children.
		/// </summary>
		// Token: 0x0601D6C7 RID: 120519 RVA: 0x00298D80 File Offset: 0x00296F80
		public vtkXMLDataElement FindNestedElementWithNameAndAttribute(string name, string att_name, string att_value)
		{
			vtkXMLDataElement vtkXMLDataElement = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLDataElement.vtkXMLDataElement_FindNestedElementWithNameAndAttribute_06(base.GetCppThis(), name, att_name, att_value, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataElement = (vtkXMLDataElement)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataElement.Register(null);
				}
			}
			return vtkXMLDataElement;
		}

		// Token: 0x0601D6C8 RID: 120520
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataElement_FindNestedElementWithNameAndId_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string id, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Find the first nested element with the given id, given name, or given
		/// name and id.
		/// WARNING: the search is only performed on the children, not
		/// the grand-children.
		/// </summary>
		// Token: 0x0601D6C9 RID: 120521 RVA: 0x00298DF4 File Offset: 0x00296FF4
		public vtkXMLDataElement FindNestedElementWithNameAndId(string name, string id)
		{
			vtkXMLDataElement vtkXMLDataElement = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLDataElement.vtkXMLDataElement_FindNestedElementWithNameAndId_07(base.GetCppThis(), name, id, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataElement = (vtkXMLDataElement)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataElement.Register(null);
				}
			}
			return vtkXMLDataElement;
		}

		// Token: 0x0601D6CA RID: 120522
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataElement_GetAttribute_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get the attribute with the given name.  If it doesn't exist,
		/// returns 0.
		/// </summary>
		// Token: 0x0601D6CB RID: 120523 RVA: 0x00298E68 File Offset: 0x00297068
		public string GetAttribute(string name)
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLDataElement.vtkXMLDataElement_GetAttribute_08(base.GetCppThis(), name));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601D6CC RID: 120524
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLDataElement_GetAttributeEncoding_09(HandleRef pThis);

		/// <summary>
		/// Get/Set the internal character encoding of the attributes.
		/// Default type is VTK_ENCODING_UTF_8.
		/// Note that a vtkXMLDataParser has its own AttributesEncoding ivar. If
		/// this ivar is set to something other than VTK_ENCODING_NONE, it will be
		/// used to set the attribute encoding of each vtkXMLDataElement
		/// created by this vtkXMLDataParser.
		/// </summary>
		// Token: 0x0601D6CD RID: 120525 RVA: 0x00298EA4 File Offset: 0x002970A4
		public virtual int GetAttributeEncoding()
		{
			return vtkXMLDataElement.vtkXMLDataElement_GetAttributeEncoding_09(base.GetCppThis());
		}

		// Token: 0x0601D6CE RID: 120526
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLDataElement_GetAttributeEncodingMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Get/Set the internal character encoding of the attributes.
		/// Default type is VTK_ENCODING_UTF_8.
		/// Note that a vtkXMLDataParser has its own AttributesEncoding ivar. If
		/// this ivar is set to something other than VTK_ENCODING_NONE, it will be
		/// used to set the attribute encoding of each vtkXMLDataElement
		/// created by this vtkXMLDataParser.
		/// </summary>
		// Token: 0x0601D6CF RID: 120527 RVA: 0x00298EC4 File Offset: 0x002970C4
		public virtual int GetAttributeEncodingMaxValue()
		{
			return vtkXMLDataElement.vtkXMLDataElement_GetAttributeEncodingMaxValue_10(base.GetCppThis());
		}

		// Token: 0x0601D6D0 RID: 120528
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLDataElement_GetAttributeEncodingMinValue_11(HandleRef pThis);

		/// <summary>
		/// Get/Set the internal character encoding of the attributes.
		/// Default type is VTK_ENCODING_UTF_8.
		/// Note that a vtkXMLDataParser has its own AttributesEncoding ivar. If
		/// this ivar is set to something other than VTK_ENCODING_NONE, it will be
		/// used to set the attribute encoding of each vtkXMLDataElement
		/// created by this vtkXMLDataParser.
		/// </summary>
		// Token: 0x0601D6D1 RID: 120529 RVA: 0x00298EE4 File Offset: 0x002970E4
		public virtual int GetAttributeEncodingMinValue()
		{
			return vtkXMLDataElement.vtkXMLDataElement_GetAttributeEncodingMinValue_11(base.GetCppThis());
		}

		// Token: 0x0601D6D2 RID: 120530
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataElement_GetAttributeName_12(HandleRef pThis, int idx);

		/// <summary>
		/// Get the n-th attribute name.
		/// Returns 0 if there is no such attribute.
		/// </summary>
		// Token: 0x0601D6D3 RID: 120531 RVA: 0x00298F04 File Offset: 0x00297104
		public string GetAttributeName(int idx)
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLDataElement.vtkXMLDataElement_GetAttributeName_12(base.GetCppThis(), idx));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601D6D4 RID: 120532
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataElement_GetAttributeValue_13(HandleRef pThis, int idx);

		/// <summary>
		/// Get the n-th attribute value.
		/// Returns 0 if there is no such attribute.
		/// </summary>
		// Token: 0x0601D6D5 RID: 120533 RVA: 0x00298F40 File Offset: 0x00297140
		public string GetAttributeValue(int idx)
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLDataElement.vtkXMLDataElement_GetAttributeValue_13(base.GetCppThis(), idx));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601D6D6 RID: 120534
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataElement_GetCharacterData_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the character data between XML start/end tags.
		/// </summary>
		// Token: 0x0601D6D7 RID: 120535 RVA: 0x00298F7C File Offset: 0x0029717C
		public virtual string GetCharacterData()
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLDataElement.vtkXMLDataElement_GetCharacterData_14(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601D6D8 RID: 120536
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLDataElement_GetCharacterDataWidth_15(HandleRef pThis);

		/// <summary>
		/// Get/Set the width (in number of fields) that character
		/// data (that between open and closing tags ie. \&lt;X\&gt; ... \&lt;/X\&gt;)
		/// is printed. If the width is less than one the tag's character
		/// data is printed all on one line. If it is greater than one
		/// the character data is streamed insterting line feeds every
		/// width number of fields. See PrintXML.
		/// </summary>
		// Token: 0x0601D6D9 RID: 120537 RVA: 0x00298FB8 File Offset: 0x002971B8
		public virtual int GetCharacterDataWidth()
		{
			return vtkXMLDataElement.vtkXMLDataElement_GetCharacterDataWidth_15(base.GetCppThis());
		}

		// Token: 0x0601D6DA RID: 120538
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataElement_GetId_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the value of the id attribute of the element, if any.
		/// </summary>
		// Token: 0x0601D6DB RID: 120539 RVA: 0x00298FD8 File Offset: 0x002971D8
		public virtual string GetId()
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLDataElement.vtkXMLDataElement_GetId_16(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601D6DC RID: 120540
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataElement_GetName_17(HandleRef pThis);

		/// <summary>
		/// Set/Get the name of the element.  This is its XML tag.
		/// </summary>
		// Token: 0x0601D6DD RID: 120541 RVA: 0x00299014 File Offset: 0x00297214
		public virtual string GetName()
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLDataElement.vtkXMLDataElement_GetName_17(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601D6DE RID: 120542
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataElement_GetNestedElement_18(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the element nested in this one at the given index.
		/// </summary>
		// Token: 0x0601D6DF RID: 120543 RVA: 0x00299050 File Offset: 0x00297250
		public vtkXMLDataElement GetNestedElement(int index)
		{
			vtkXMLDataElement vtkXMLDataElement = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLDataElement.vtkXMLDataElement_GetNestedElement_18(base.GetCppThis(), index, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataElement = (vtkXMLDataElement)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataElement.Register(null);
				}
			}
			return vtkXMLDataElement;
		}

		// Token: 0x0601D6E0 RID: 120544
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLDataElement_GetNumberOfAttributes_19(HandleRef pThis);

		/// <summary>
		/// Get the number of attributes.
		/// </summary>
		// Token: 0x0601D6E1 RID: 120545 RVA: 0x002990C0 File Offset: 0x002972C0
		public virtual int GetNumberOfAttributes()
		{
			return vtkXMLDataElement.vtkXMLDataElement_GetNumberOfAttributes_19(base.GetCppThis());
		}

		// Token: 0x0601D6E2 RID: 120546
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLDataElement_GetNumberOfGenerationsFromBase_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D6E3 RID: 120547 RVA: 0x002990E0 File Offset: 0x002972E0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLDataElement.vtkXMLDataElement_GetNumberOfGenerationsFromBase_20(base.GetCppThis(), type);
		}

		// Token: 0x0601D6E4 RID: 120548
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLDataElement_GetNumberOfGenerationsFromBaseType_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D6E5 RID: 120549 RVA: 0x00299100 File Offset: 0x00297300
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLDataElement.vtkXMLDataElement_GetNumberOfGenerationsFromBaseType_21(type);
		}

		// Token: 0x0601D6E6 RID: 120550
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLDataElement_GetNumberOfNestedElements_22(HandleRef pThis);

		/// <summary>
		/// Get the number of elements nested in this one.
		/// </summary>
		// Token: 0x0601D6E7 RID: 120551 RVA: 0x0029911C File Offset: 0x0029731C
		public int GetNumberOfNestedElements()
		{
			return vtkXMLDataElement.vtkXMLDataElement_GetNumberOfNestedElements_22(base.GetCppThis());
		}

		// Token: 0x0601D6E8 RID: 120552
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataElement_GetParent_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the parent of this element.
		/// </summary>
		// Token: 0x0601D6E9 RID: 120553 RVA: 0x0029913C File Offset: 0x0029733C
		public vtkXMLDataElement GetParent()
		{
			vtkXMLDataElement vtkXMLDataElement = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLDataElement.vtkXMLDataElement_GetParent_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataElement = (vtkXMLDataElement)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataElement.Register(null);
				}
			}
			return vtkXMLDataElement;
		}

		// Token: 0x0601D6EA RID: 120554
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataElement_GetRoot_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get root of the XML tree this element is part of.
		/// </summary>
		// Token: 0x0601D6EB RID: 120555 RVA: 0x002991AC File Offset: 0x002973AC
		public virtual vtkXMLDataElement GetRoot()
		{
			vtkXMLDataElement vtkXMLDataElement = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLDataElement.vtkXMLDataElement_GetRoot_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataElement = (vtkXMLDataElement)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataElement.Register(null);
				}
			}
			return vtkXMLDataElement;
		}

		// Token: 0x0601D6EC RID: 120556
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLDataElement_GetScalarAttribute_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref int value);

		/// <summary>
		/// Get the attribute with the given name and converted to a scalar
		/// value.  Returns whether value was extracted.
		/// </summary>
		// Token: 0x0601D6ED RID: 120557 RVA: 0x0029921C File Offset: 0x0029741C
		public int GetScalarAttribute(string name, ref int value)
		{
			return vtkXMLDataElement.vtkXMLDataElement_GetScalarAttribute_25(base.GetCppThis(), name, ref value);
		}

		// Token: 0x0601D6EE RID: 120558
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLDataElement_GetScalarAttribute_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref float value);

		/// <summary>
		/// Get the attribute with the given name and converted to a scalar
		/// value.  Returns whether value was extracted.
		/// </summary>
		// Token: 0x0601D6EF RID: 120559 RVA: 0x00299240 File Offset: 0x00297440
		public int GetScalarAttribute(string name, ref float value)
		{
			return vtkXMLDataElement.vtkXMLDataElement_GetScalarAttribute_26(base.GetCppThis(), name, ref value);
		}

		// Token: 0x0601D6F0 RID: 120560
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLDataElement_GetScalarAttribute_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref double value);

		/// <summary>
		/// Get the attribute with the given name and converted to a scalar
		/// value.  Returns whether value was extracted.
		/// </summary>
		// Token: 0x0601D6F1 RID: 120561 RVA: 0x00299264 File Offset: 0x00297464
		public int GetScalarAttribute(string name, ref double value)
		{
			return vtkXMLDataElement.vtkXMLDataElement_GetScalarAttribute_27(base.GetCppThis(), name, ref value);
		}

		// Token: 0x0601D6F2 RID: 120562
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLDataElement_GetScalarAttribute_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref uint value);

		/// <summary>
		/// Get the attribute with the given name and converted to a scalar
		/// value.  Returns whether value was extracted.
		/// </summary>
		// Token: 0x0601D6F3 RID: 120563 RVA: 0x00299288 File Offset: 0x00297488
		public int GetScalarAttribute(string name, ref uint value)
		{
			return vtkXMLDataElement.vtkXMLDataElement_GetScalarAttribute_28(base.GetCppThis(), name, ref value);
		}

		// Token: 0x0601D6F4 RID: 120564
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLDataElement_GetScalarAttribute_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref long value);

		/// <summary>
		/// Set the attribute with the given name.
		/// </summary>
		// Token: 0x0601D6F5 RID: 120565 RVA: 0x002992AC File Offset: 0x002974AC
		public int GetScalarAttribute(string name, ref long value)
		{
			return vtkXMLDataElement.vtkXMLDataElement_GetScalarAttribute_29(base.GetCppThis(), name, ref value);
		}

		// Token: 0x0601D6F6 RID: 120566
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLDataElement_GetScalarAttribute_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref ulong value);

		/// <summary>
		/// Set the attribute with the given name.
		/// </summary>
		// Token: 0x0601D6F7 RID: 120567 RVA: 0x002992D0 File Offset: 0x002974D0
		public int GetScalarAttribute(string name, ref ulong value)
		{
			return vtkXMLDataElement.vtkXMLDataElement_GetScalarAttribute_30(base.GetCppThis(), name, ref value);
		}

		// Token: 0x0601D6F8 RID: 120568
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLDataElement_GetVectorAttribute_31(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int length, IntPtr value);

		/// <summary>
		/// Get the attribute with the given name and converted to a scalar
		/// value.  Returns length of vector read.
		/// </summary>
		// Token: 0x0601D6F9 RID: 120569 RVA: 0x002992F4 File Offset: 0x002974F4
		public int GetVectorAttribute(string name, int length, IntPtr value)
		{
			return vtkXMLDataElement.vtkXMLDataElement_GetVectorAttribute_31(base.GetCppThis(), name, length, value);
		}

		// Token: 0x0601D6FA RID: 120570
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLDataElement_GetWordTypeAttribute_32(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref int value);

		/// <summary>
		/// Get the attribute with the given name and converted to a word type.
		/// Word types can be `VTK_TYPE_FLOAT32`, `VTK_TYPE_FLOAT64`, `VTK_INT8`,
		/// `VTK_UINT8`, `VTK_INT16`, `VTK_UINT16`, `VTK_INT32`, `VTK_UINT32`,
		/// `VTK_INT64`, `VTK_UINT64`, `VTK_STRING`, or `VTK_BIT`.
		/// </summary>
		// Token: 0x0601D6FB RID: 120571 RVA: 0x00299318 File Offset: 0x00297518
		public int GetWordTypeAttribute(string name, ref int value)
		{
			return vtkXMLDataElement.vtkXMLDataElement_GetWordTypeAttribute_32(base.GetCppThis(), name, ref value);
		}

		// Token: 0x0601D6FC RID: 120572
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLDataElement_GetXMLByteIndex_33(HandleRef pThis);

		/// <summary>
		/// Set/Get the offset from the beginning of the XML document to this element.
		/// </summary>
		// Token: 0x0601D6FD RID: 120573 RVA: 0x0029933C File Offset: 0x0029753C
		public virtual long GetXMLByteIndex()
		{
			return vtkXMLDataElement.vtkXMLDataElement_GetXMLByteIndex_33(base.GetCppThis());
		}

		// Token: 0x0601D6FE RID: 120574
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLDataElement_IsA_34(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D6FF RID: 120575 RVA: 0x0029935C File Offset: 0x0029755C
		public override int IsA(string type)
		{
			return vtkXMLDataElement.vtkXMLDataElement_IsA_34(base.GetCppThis(), type);
		}

		// Token: 0x0601D700 RID: 120576
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLDataElement_IsEqualTo_35(HandleRef pThis, HandleRef elem);

		/// <summary>
		/// Check if the instance has the same name, attributes, character data
		/// and nested elements contents than the given element (this method is
		/// applied recursively on the nested elements, and they must be stored in
		/// the same order).
		/// Warning: Id, Parent, XMLByteIndex are ignored.
		/// </summary>
		// Token: 0x0601D701 RID: 120577 RVA: 0x0029937C File Offset: 0x0029757C
		public virtual int IsEqualTo(vtkXMLDataElement elem)
		{
			return vtkXMLDataElement.vtkXMLDataElement_IsEqualTo_35(base.GetCppThis(), (elem == null) ? default(HandleRef) : elem.GetCppThis());
		}

		// Token: 0x0601D702 RID: 120578
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLDataElement_IsTypeOf_36([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D703 RID: 120579 RVA: 0x002993B0 File Offset: 0x002975B0
		public new static int IsTypeOf(string type)
		{
			return vtkXMLDataElement.vtkXMLDataElement_IsTypeOf_36(type);
		}

		// Token: 0x0601D704 RID: 120580
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataElement_LookupElement_37(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string id, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Lookup the element with the given id, starting at this scope.
		/// </summary>
		// Token: 0x0601D705 RID: 120581 RVA: 0x002993CC File Offset: 0x002975CC
		public vtkXMLDataElement LookupElement(string id)
		{
			vtkXMLDataElement vtkXMLDataElement = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLDataElement.vtkXMLDataElement_LookupElement_37(base.GetCppThis(), id, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataElement = (vtkXMLDataElement)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataElement.Register(null);
				}
			}
			return vtkXMLDataElement;
		}

		// Token: 0x0601D706 RID: 120582
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataElement_LookupElementWithName_38(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Find the first nested element with given name.
		/// WARNING: the search is performed on the whole XML tree.
		/// </summary>
		// Token: 0x0601D707 RID: 120583 RVA: 0x0029943C File Offset: 0x0029763C
		public vtkXMLDataElement LookupElementWithName(string name)
		{
			vtkXMLDataElement vtkXMLDataElement = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLDataElement.vtkXMLDataElement_LookupElementWithName_38(base.GetCppThis(), name, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataElement = (vtkXMLDataElement)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataElement.Register(null);
				}
			}
			return vtkXMLDataElement;
		}

		// Token: 0x0601D708 RID: 120584
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataElement_NewInstance_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D709 RID: 120585 RVA: 0x002994AC File Offset: 0x002976AC
		public new vtkXMLDataElement NewInstance()
		{
			vtkXMLDataElement result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLDataElement.vtkXMLDataElement_NewInstance_40(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLDataElement)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D70A RID: 120586
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLDataElement_PrintXML_41(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname);

		/// <summary>
		/// Prints element tree as XML.
		/// </summary>
		// Token: 0x0601D70B RID: 120587 RVA: 0x00299506 File Offset: 0x00297706
		public void PrintXML(string fname)
		{
			vtkXMLDataElement.vtkXMLDataElement_PrintXML_41(base.GetCppThis(), fname);
		}

		// Token: 0x0601D70C RID: 120588
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLDataElement_RemoveAllAttributes_42(HandleRef pThis);

		/// <summary>
		/// Remove one or all attributes.
		/// </summary>
		// Token: 0x0601D70D RID: 120589 RVA: 0x00299516 File Offset: 0x00297716
		public virtual void RemoveAllAttributes()
		{
			vtkXMLDataElement.vtkXMLDataElement_RemoveAllAttributes_42(base.GetCppThis());
		}

		// Token: 0x0601D70E RID: 120590
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLDataElement_RemoveAllNestedElements_43(HandleRef pThis);

		/// <summary>
		/// Remove all nested elements.
		/// </summary>
		// Token: 0x0601D70F RID: 120591 RVA: 0x00299525 File Offset: 0x00297725
		public virtual void RemoveAllNestedElements()
		{
			vtkXMLDataElement.vtkXMLDataElement_RemoveAllNestedElements_43(base.GetCppThis());
		}

		// Token: 0x0601D710 RID: 120592
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLDataElement_RemoveAttribute_44(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Remove one or all attributes.
		/// </summary>
		// Token: 0x0601D711 RID: 120593 RVA: 0x00299534 File Offset: 0x00297734
		public virtual void RemoveAttribute(string name)
		{
			vtkXMLDataElement.vtkXMLDataElement_RemoveAttribute_44(base.GetCppThis(), name);
		}

		// Token: 0x0601D712 RID: 120594
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLDataElement_RemoveNestedElement_45(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Remove nested element.
		/// </summary>
		// Token: 0x0601D713 RID: 120595 RVA: 0x00299544 File Offset: 0x00297744
		public virtual void RemoveNestedElement(vtkXMLDataElement arg0)
		{
			vtkXMLDataElement.vtkXMLDataElement_RemoveNestedElement_45(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601D714 RID: 120596
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataElement_SafeDownCast_46(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D715 RID: 120597 RVA: 0x00299574 File Offset: 0x00297774
		public new static vtkXMLDataElement SafeDownCast(vtkObjectBase o)
		{
			vtkXMLDataElement vtkXMLDataElement = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLDataElement.vtkXMLDataElement_SafeDownCast_46((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataElement = (vtkXMLDataElement)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataElement.Register(null);
				}
			}
			return vtkXMLDataElement;
		}

		// Token: 0x0601D716 RID: 120598
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLDataElement_SetAttribute_47(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string value);

		/// <summary>
		/// Set the attribute with the given name and value. If it doesn't exist,
		/// adds it.
		/// </summary>
		// Token: 0x0601D717 RID: 120599 RVA: 0x002995F3 File Offset: 0x002977F3
		public void SetAttribute(string name, string value)
		{
			vtkXMLDataElement.vtkXMLDataElement_SetAttribute_47(base.GetCppThis(), name, value);
		}

		// Token: 0x0601D718 RID: 120600
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLDataElement_SetAttributeEncoding_48(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the internal character encoding of the attributes.
		/// Default type is VTK_ENCODING_UTF_8.
		/// Note that a vtkXMLDataParser has its own AttributesEncoding ivar. If
		/// this ivar is set to something other than VTK_ENCODING_NONE, it will be
		/// used to set the attribute encoding of each vtkXMLDataElement
		/// created by this vtkXMLDataParser.
		/// </summary>
		// Token: 0x0601D719 RID: 120601 RVA: 0x00299604 File Offset: 0x00297804
		public virtual void SetAttributeEncoding(int _arg)
		{
			vtkXMLDataElement.vtkXMLDataElement_SetAttributeEncoding_48(base.GetCppThis(), _arg);
		}

		// Token: 0x0601D71A RID: 120602
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLDataElement_SetCharacterData_49(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string data, int length);

		/// <summary>
		/// Set/Get the character data between XML start/end tags.
		/// </summary>
		// Token: 0x0601D71B RID: 120603 RVA: 0x00299614 File Offset: 0x00297814
		public void SetCharacterData(string data, int length)
		{
			vtkXMLDataElement.vtkXMLDataElement_SetCharacterData_49(base.GetCppThis(), data, length);
		}

		// Token: 0x0601D71C RID: 120604
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLDataElement_SetCharacterDataWidth_50(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the width (in number of fields) that character
		/// data (that between open and closing tags ie. \&lt;X\&gt; ... \&lt;/X\&gt;)
		/// is printed. If the width is less than one the tag's character
		/// data is printed all on one line. If it is greater than one
		/// the character data is streamed insterting line feeds every
		/// width number of fields. See PrintXML.
		/// </summary>
		// Token: 0x0601D71D RID: 120605 RVA: 0x00299625 File Offset: 0x00297825
		public virtual void SetCharacterDataWidth(int _arg)
		{
			vtkXMLDataElement.vtkXMLDataElement_SetCharacterDataWidth_50(base.GetCppThis(), _arg);
		}

		// Token: 0x0601D71E RID: 120606
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLDataElement_SetDoubleAttribute_51(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, double value);

		/// <summary>
		/// Set the attribute with the given name.
		/// We can not use the same GetScalarAttribute() construct since
		/// the compiler will not be able to resolve between
		/// SetAttribute(..., int) and SetAttribute(..., unsigned long).
		/// </summary>
		// Token: 0x0601D71F RID: 120607 RVA: 0x00299635 File Offset: 0x00297835
		public void SetDoubleAttribute(string name, double value)
		{
			vtkXMLDataElement.vtkXMLDataElement_SetDoubleAttribute_51(base.GetCppThis(), name, value);
		}

		// Token: 0x0601D720 RID: 120608
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLDataElement_SetFloatAttribute_52(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, float value);

		/// <summary>
		/// Set the attribute with the given name.
		/// We can not use the same GetScalarAttribute() construct since
		/// the compiler will not be able to resolve between
		/// SetAttribute(..., int) and SetAttribute(..., unsigned long).
		/// </summary>
		// Token: 0x0601D721 RID: 120609 RVA: 0x00299646 File Offset: 0x00297846
		public void SetFloatAttribute(string name, float value)
		{
			vtkXMLDataElement.vtkXMLDataElement_SetFloatAttribute_52(base.GetCppThis(), name, value);
		}

		// Token: 0x0601D722 RID: 120610
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLDataElement_SetId_53(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the value of the id attribute of the element, if any.
		/// </summary>
		// Token: 0x0601D723 RID: 120611 RVA: 0x00299657 File Offset: 0x00297857
		public virtual void SetId(string _arg)
		{
			vtkXMLDataElement.vtkXMLDataElement_SetId_53(base.GetCppThis(), _arg);
		}

		// Token: 0x0601D724 RID: 120612
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLDataElement_SetIntAttribute_54(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int value);

		/// <summary>
		/// Set the attribute with the given name.
		/// We can not use the same GetScalarAttribute() construct since
		/// the compiler will not be able to resolve between
		/// SetAttribute(..., int) and SetAttribute(..., unsigned long).
		/// </summary>
		// Token: 0x0601D725 RID: 120613 RVA: 0x00299667 File Offset: 0x00297867
		public void SetIntAttribute(string name, int value)
		{
			vtkXMLDataElement.vtkXMLDataElement_SetIntAttribute_54(base.GetCppThis(), name, value);
		}

		// Token: 0x0601D726 RID: 120614
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLDataElement_SetName_55(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the name of the element.  This is its XML tag.
		/// </summary>
		// Token: 0x0601D727 RID: 120615 RVA: 0x00299678 File Offset: 0x00297878
		public virtual void SetName(string _arg)
		{
			vtkXMLDataElement.vtkXMLDataElement_SetName_55(base.GetCppThis(), _arg);
		}

		// Token: 0x0601D728 RID: 120616
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLDataElement_SetParent_56(HandleRef pThis, HandleRef parent);

		/// <summary>
		/// Set/Get the parent of this element.
		/// </summary>
		// Token: 0x0601D729 RID: 120617 RVA: 0x00299688 File Offset: 0x00297888
		public void SetParent(vtkXMLDataElement parent)
		{
			vtkXMLDataElement.vtkXMLDataElement_SetParent_56(base.GetCppThis(), (parent == null) ? default(HandleRef) : parent.GetCppThis());
		}

		// Token: 0x0601D72A RID: 120618
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLDataElement_SetUnsignedLongAttribute_57(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, uint value);

		/// <summary>
		/// Set the attribute with the given name.
		/// We can not use the same GetScalarAttribute() construct since
		/// the compiler will not be able to resolve between
		/// SetAttribute(..., int) and SetAttribute(..., unsigned long).
		/// </summary>
		// Token: 0x0601D72B RID: 120619 RVA: 0x002996B7 File Offset: 0x002978B7
		public void SetUnsignedLongAttribute(string name, uint value)
		{
			vtkXMLDataElement.vtkXMLDataElement_SetUnsignedLongAttribute_57(base.GetCppThis(), name, value);
		}

		// Token: 0x0601D72C RID: 120620
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLDataElement_SetVectorAttribute_58(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int length, IntPtr value);

		/// <summary>
		/// Set the attribute with the given name.
		/// </summary>
		// Token: 0x0601D72D RID: 120621 RVA: 0x002996C8 File Offset: 0x002978C8
		public void SetVectorAttribute(string name, int length, IntPtr value)
		{
			vtkXMLDataElement.vtkXMLDataElement_SetVectorAttribute_58(base.GetCppThis(), name, length, value);
		}

		// Token: 0x0601D72E RID: 120622
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLDataElement_SetXMLByteIndex_59(HandleRef pThis, long _arg);

		/// <summary>
		/// Set/Get the offset from the beginning of the XML document to this element.
		/// </summary>
		// Token: 0x0601D72F RID: 120623 RVA: 0x002996DA File Offset: 0x002978DA
		public virtual void SetXMLByteIndex(long _arg)
		{
			vtkXMLDataElement.vtkXMLDataElement_SetXMLByteIndex_59(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EEF RID: 7919
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLDataElement";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EF0 RID: 7920
		public new static readonly string MRClassNameKey = "class vtkXMLDataElement";
	}
}
