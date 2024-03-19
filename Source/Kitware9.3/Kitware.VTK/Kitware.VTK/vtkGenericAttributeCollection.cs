using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGenericAttributeCollection
	/// </summary>
	/// <remarks>
	///    a collection of attributes
	///
	/// vtkGenericAttributeCollection is a class that collects attributes
	/// (represented by vtkGenericAttribute).
	/// </remarks>
	// Token: 0x02000A4B RID: 2635
	public class vtkGenericAttributeCollection : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B7B8 RID: 112568 RVA: 0x0026775B File Offset: 0x0026595B
		static vtkGenericAttributeCollection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericAttributeCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericAttributeCollection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B7B9 RID: 112569 RVA: 0x00267783 File Offset: 0x00265983
		public vtkGenericAttributeCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B7BA RID: 112570
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericAttributeCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create an empty collection.
		/// </summary>
		// Token: 0x0601B7BB RID: 112571 RVA: 0x00267794 File Offset: 0x00265994
		public new static vtkGenericAttributeCollection New()
		{
			vtkGenericAttributeCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericAttributeCollection.vtkGenericAttributeCollection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericAttributeCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Create an empty collection.
		/// </summary>
		// Token: 0x0601B7BC RID: 112572 RVA: 0x002677E8 File Offset: 0x002659E8
		public vtkGenericAttributeCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGenericAttributeCollection.vtkGenericAttributeCollection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B7BD RID: 112573 RVA: 0x0026782C File Offset: 0x00265A2C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B7BE RID: 112574
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericAttributeCollection_DeepCopy_01(HandleRef pThis, HandleRef other);

		/// <summary>
		/// Copy, without reference counting, the other attribute array.
		/// \pre other_exists: other!=0
		/// \pre not_self: other!=this
		/// \post same_size: GetNumberOfAttributes()==other-&gt;GetNumberOfAttributes()
		/// </summary>
		// Token: 0x0601B7BF RID: 112575 RVA: 0x00267838 File Offset: 0x00265A38
		public void DeepCopy(vtkGenericAttributeCollection other)
		{
			vtkGenericAttributeCollection.vtkGenericAttributeCollection_DeepCopy_01(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}

		// Token: 0x0601B7C0 RID: 112576
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAttributeCollection_FindAttribute_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Return the index of the attribute named `name'. Return the non-negative
		/// index if found. Return -1 otherwise.
		/// \pre name_exists: name!=0
		/// \post valid_result: (result==-1) || (result&gt;=0) &amp;&amp; (result&lt;=GetNumberOfAttributes())
		/// </summary>
		// Token: 0x0601B7C1 RID: 112577 RVA: 0x00267868 File Offset: 0x00265A68
		public int FindAttribute(string name)
		{
			return vtkGenericAttributeCollection.vtkGenericAttributeCollection_FindAttribute_02(base.GetCppThis(), name);
		}

		// Token: 0x0601B7C2 RID: 112578
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAttributeCollection_GetActiveAttribute_03(HandleRef pThis);

		/// <summary>
		/// Index of the attribute to be processed (not necessarily scalar).
		/// \pre not_empty: !IsEmpty()
		/// \post valid_result: result&gt;=0 &amp;&amp; result&lt;GetNumberOfAttributes()
		/// </summary>
		// Token: 0x0601B7C3 RID: 112579 RVA: 0x00267888 File Offset: 0x00265A88
		public virtual int GetActiveAttribute()
		{
			return vtkGenericAttributeCollection.vtkGenericAttributeCollection_GetActiveAttribute_03(base.GetCppThis());
		}

		// Token: 0x0601B7C4 RID: 112580
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAttributeCollection_GetActiveComponent_04(HandleRef pThis);

		/// <summary>
		/// Component of the active attribute to be processed. -1 means module.
		/// \pre not_empty: GetNumberOfAttributes()&gt;0
		/// \post valid_result: result&gt;=-1 &amp;&amp;
		/// result&lt;GetAttribute(GetActiveAttribute())-&gt;GetNumberOfComponents()
		/// </summary>
		// Token: 0x0601B7C5 RID: 112581 RVA: 0x002678A8 File Offset: 0x00265AA8
		public virtual int GetActiveComponent()
		{
			return vtkGenericAttributeCollection.vtkGenericAttributeCollection_GetActiveComponent_04(base.GetCppThis());
		}

		// Token: 0x0601B7C6 RID: 112582
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkGenericAttributeCollection_GetActualMemorySize_05(HandleRef pThis);

		/// <summary>
		/// Actual size of the data in kibibytes (1024 bytes); only valid after the pipeline has
		/// updated. It is guaranteed to be greater than or equal to the memory
		/// required to represent the data.
		/// </summary>
		// Token: 0x0601B7C7 RID: 112583 RVA: 0x002678C8 File Offset: 0x00265AC8
		public uint GetActualMemorySize()
		{
			return vtkGenericAttributeCollection.vtkGenericAttributeCollection_GetActualMemorySize_05(base.GetCppThis());
		}

		// Token: 0x0601B7C8 RID: 112584
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericAttributeCollection_GetAttribute_06(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return a pointer to the ith instance of vtkGenericAttribute.
		/// \pre not_empty: !IsEmpty()
		/// \pre valid_i: i&gt;=0 &amp;&amp; i&lt;GetNumberOfAttributes()
		/// \post result_exists: result!=0
		/// </summary>
		// Token: 0x0601B7C9 RID: 112585 RVA: 0x002678E8 File Offset: 0x00265AE8
		public vtkGenericAttribute GetAttribute(int i)
		{
			vtkGenericAttribute vtkGenericAttribute = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericAttributeCollection.vtkGenericAttributeCollection_GetAttribute_06(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericAttribute = (vtkGenericAttribute)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericAttribute.Register(null);
				}
			}
			return vtkGenericAttribute;
		}

		// Token: 0x0601B7CA RID: 112586
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAttributeCollection_GetAttributeIndex_07(HandleRef pThis, int i);

		/// <summary>
		/// Return the index of the first component of attribute `i' in an array of
		/// format attrib0comp0 attrib0comp1 ... attrib4comp0 ...
		/// \pre valid_i: i&gt;=0 &amp;&amp; i&lt;GetNumberOfAttributes()
		/// \pre is_point_centered: GetAttribute(i)-&gt;GetCentering()==vtkPointCentered
		/// </summary>
		// Token: 0x0601B7CB RID: 112587 RVA: 0x00267958 File Offset: 0x00265B58
		public int GetAttributeIndex(int i)
		{
			return vtkGenericAttributeCollection.vtkGenericAttributeCollection_GetAttributeIndex_07(base.GetCppThis(), i);
		}

		// Token: 0x0601B7CC RID: 112588
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericAttributeCollection_GetAttributesToInterpolate_08(HandleRef pThis);

		/// <summary>
		/// Indices of attributes to interpolate.
		/// \pre not_empty: !IsEmpty()
		/// \post valid_result: GetNumberOfAttributesToInterpolate()&gt;0
		/// </summary>
		// Token: 0x0601B7CD RID: 112589 RVA: 0x00267978 File Offset: 0x00265B78
		public IntPtr GetAttributesToInterpolate()
		{
			return vtkGenericAttributeCollection.vtkGenericAttributeCollection_GetAttributesToInterpolate_08(base.GetCppThis());
		}

		// Token: 0x0601B7CE RID: 112590
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkGenericAttributeCollection_GetMTime_09(HandleRef pThis);

		/// <summary>
		/// vtkAttributeCollection is a composite object and needs to check each
		/// member of its collection for modified time.
		/// </summary>
		// Token: 0x0601B7CF RID: 112591 RVA: 0x00267998 File Offset: 0x00265B98
		public override ulong GetMTime()
		{
			return vtkGenericAttributeCollection.vtkGenericAttributeCollection_GetMTime_09(base.GetCppThis());
		}

		// Token: 0x0601B7D0 RID: 112592
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAttributeCollection_GetMaxNumberOfComponents_10(HandleRef pThis);

		/// <summary>
		/// Maximum number of components encountered among all attributes.
		/// \post positive_result: result&gt;=0
		/// \post valid_result: result&lt;=GetNumberOfComponents()
		/// </summary>
		// Token: 0x0601B7D1 RID: 112593 RVA: 0x002679B8 File Offset: 0x00265BB8
		public int GetMaxNumberOfComponents()
		{
			return vtkGenericAttributeCollection.vtkGenericAttributeCollection_GetMaxNumberOfComponents_10(base.GetCppThis());
		}

		// Token: 0x0601B7D2 RID: 112594
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAttributeCollection_GetNumberOfAttributes_11(HandleRef pThis);

		/// <summary>
		/// Return the number of attributes (e.g., instances of vtkGenericAttribute)
		/// in the collection.
		/// \post positive_result: result&gt;=0
		/// </summary>
		// Token: 0x0601B7D3 RID: 112595 RVA: 0x002679D8 File Offset: 0x00265BD8
		public int GetNumberOfAttributes()
		{
			return vtkGenericAttributeCollection.vtkGenericAttributeCollection_GetNumberOfAttributes_11(base.GetCppThis());
		}

		// Token: 0x0601B7D4 RID: 112596
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAttributeCollection_GetNumberOfAttributesToInterpolate_12(HandleRef pThis);

		/// <summary>
		/// Number of attributes to interpolate.
		/// \pre not_empty: !IsEmpty()
		/// \post positive_result: result&gt;=0
		/// </summary>
		// Token: 0x0601B7D5 RID: 112597 RVA: 0x002679F8 File Offset: 0x00265BF8
		public virtual int GetNumberOfAttributesToInterpolate()
		{
			return vtkGenericAttributeCollection.vtkGenericAttributeCollection_GetNumberOfAttributesToInterpolate_12(base.GetCppThis());
		}

		// Token: 0x0601B7D6 RID: 112598
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAttributeCollection_GetNumberOfComponents_13(HandleRef pThis);

		/// <summary>
		/// Return the number of components. This is the sum of all components
		/// found in all attributes.
		/// \post positive_result: result&gt;=0
		/// </summary>
		// Token: 0x0601B7D7 RID: 112599 RVA: 0x00267A18 File Offset: 0x00265C18
		public int GetNumberOfComponents()
		{
			return vtkGenericAttributeCollection.vtkGenericAttributeCollection_GetNumberOfComponents_13(base.GetCppThis());
		}

		// Token: 0x0601B7D8 RID: 112600
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericAttributeCollection_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type definition and print methods for a VTK class.
		/// </summary>
		// Token: 0x0601B7D9 RID: 112601 RVA: 0x00267A38 File Offset: 0x00265C38
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGenericAttributeCollection.vtkGenericAttributeCollection_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x0601B7DA RID: 112602
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericAttributeCollection_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type definition and print methods for a VTK class.
		/// </summary>
		// Token: 0x0601B7DB RID: 112603 RVA: 0x00267A58 File Offset: 0x00265C58
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGenericAttributeCollection.vtkGenericAttributeCollection_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x0601B7DC RID: 112604
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAttributeCollection_GetNumberOfPointCenteredComponents_16(HandleRef pThis);

		/// <summary>
		/// Return the number of components. This is the sum of all components
		/// found in all point centered attributes.
		/// \post positive_result: result&gt;=0
		/// </summary>
		// Token: 0x0601B7DD RID: 112605 RVA: 0x00267A74 File Offset: 0x00265C74
		public int GetNumberOfPointCenteredComponents()
		{
			return vtkGenericAttributeCollection.vtkGenericAttributeCollection_GetNumberOfPointCenteredComponents_16(base.GetCppThis());
		}

		// Token: 0x0601B7DE RID: 112606
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAttributeCollection_HasAttribute_17(HandleRef pThis, int size, IntPtr attributes, int attribute);

		/// <summary>
		/// Does the array `attributes' of size `size' have `attribute'?
		/// \pre positive_size: size&gt;=0
		/// \pre valid_attributes: size&gt;0 implies attributes!=0
		/// </summary>
		// Token: 0x0601B7DF RID: 112607 RVA: 0x00267A94 File Offset: 0x00265C94
		public int HasAttribute(int size, IntPtr attributes, int attribute)
		{
			return vtkGenericAttributeCollection.vtkGenericAttributeCollection_HasAttribute_17(base.GetCppThis(), size, attributes, attribute);
		}

		// Token: 0x0601B7E0 RID: 112608
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericAttributeCollection_InsertAttribute_18(HandleRef pThis, int i, HandleRef a);

		/// <summary>
		/// Replace the attribute at index `i' by `a'.
		/// \pre not_empty: !IsEmpty()
		/// \pre a_exists: a!=0
		/// \pre valid_i: i&gt;=0 &amp;&amp; i&lt;GetNumberOfAttributes()
		/// \post same_size: GetNumberOfAttributes()==old GetNumberOfAttributes()
		/// \post item_is_set: GetAttribute(i)==a
		/// </summary>
		// Token: 0x0601B7E1 RID: 112609 RVA: 0x00267AB8 File Offset: 0x00265CB8
		public void InsertAttribute(int i, vtkGenericAttribute a)
		{
			vtkGenericAttributeCollection.vtkGenericAttributeCollection_InsertAttribute_18(base.GetCppThis(), i, (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		// Token: 0x0601B7E2 RID: 112610
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericAttributeCollection_InsertNextAttribute_19(HandleRef pThis, HandleRef a);

		/// <summary>
		/// Add the attribute `a' to the end of the collection.
		/// \pre a_exists: a!=0
		/// \post more_items: GetNumberOfAttributes()==old GetNumberOfAttributes()+1
		/// \post a_is_set: GetAttribute(GetNumberOfAttributes()-1)==a
		/// </summary>
		// Token: 0x0601B7E3 RID: 112611 RVA: 0x00267AE8 File Offset: 0x00265CE8
		public void InsertNextAttribute(vtkGenericAttribute a)
		{
			vtkGenericAttributeCollection.vtkGenericAttributeCollection_InsertNextAttribute_19(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		// Token: 0x0601B7E4 RID: 112612
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAttributeCollection_IsA_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type definition and print methods for a VTK class.
		/// </summary>
		// Token: 0x0601B7E5 RID: 112613 RVA: 0x00267B18 File Offset: 0x00265D18
		public override int IsA(string type)
		{
			return vtkGenericAttributeCollection.vtkGenericAttributeCollection_IsA_20(base.GetCppThis(), type);
		}

		// Token: 0x0601B7E6 RID: 112614
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAttributeCollection_IsEmpty_21(HandleRef pThis);

		/// <summary>
		/// Indicate whether the collection contains any attributes.
		/// \post definition: result==(GetNumberOfAttributes()==0)
		/// </summary>
		// Token: 0x0601B7E7 RID: 112615 RVA: 0x00267B38 File Offset: 0x00265D38
		public int IsEmpty()
		{
			return vtkGenericAttributeCollection.vtkGenericAttributeCollection_IsEmpty_21(base.GetCppThis());
		}

		// Token: 0x0601B7E8 RID: 112616
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAttributeCollection_IsTypeOf_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type definition and print methods for a VTK class.
		/// </summary>
		// Token: 0x0601B7E9 RID: 112617 RVA: 0x00267B58 File Offset: 0x00265D58
		public new static int IsTypeOf(string type)
		{
			return vtkGenericAttributeCollection.vtkGenericAttributeCollection_IsTypeOf_22(type);
		}

		// Token: 0x0601B7EA RID: 112618
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericAttributeCollection_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard type definition and print methods for a VTK class.
		/// </summary>
		// Token: 0x0601B7EB RID: 112619 RVA: 0x00267B74 File Offset: 0x00265D74
		public new vtkGenericAttributeCollection NewInstance()
		{
			vtkGenericAttributeCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericAttributeCollection.vtkGenericAttributeCollection_NewInstance_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericAttributeCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B7EC RID: 112620
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericAttributeCollection_RemoveAttribute_25(HandleRef pThis, int i);

		/// <summary>
		/// Remove the attribute at `i'.
		/// \pre not_empty: !IsEmpty()
		/// \pre valid_i: i&gt;=0 &amp;&amp; i&lt;GetNumberOfAttributes()
		/// \post fewer_items: GetNumberOfAttributes()==old GetNumberOfAttributes()-1
		/// </summary>
		// Token: 0x0601B7ED RID: 112621 RVA: 0x00267BCE File Offset: 0x00265DCE
		public void RemoveAttribute(int i)
		{
			vtkGenericAttributeCollection.vtkGenericAttributeCollection_RemoveAttribute_25(base.GetCppThis(), i);
		}

		// Token: 0x0601B7EE RID: 112622
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericAttributeCollection_Reset_26(HandleRef pThis);

		/// <summary>
		/// Remove all attributes.
		/// \post is_empty: GetNumberOfAttributes()==0
		/// </summary>
		// Token: 0x0601B7EF RID: 112623 RVA: 0x00267BDE File Offset: 0x00265DDE
		public void Reset()
		{
			vtkGenericAttributeCollection.vtkGenericAttributeCollection_Reset_26(base.GetCppThis());
		}

		// Token: 0x0601B7F0 RID: 112624
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericAttributeCollection_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard type definition and print methods for a VTK class.
		/// </summary>
		// Token: 0x0601B7F1 RID: 112625 RVA: 0x00267BF0 File Offset: 0x00265DF0
		public new static vtkGenericAttributeCollection SafeDownCast(vtkObjectBase o)
		{
			vtkGenericAttributeCollection vtkGenericAttributeCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericAttributeCollection.vtkGenericAttributeCollection_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericAttributeCollection = (vtkGenericAttributeCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericAttributeCollection.Register(null);
				}
			}
			return vtkGenericAttributeCollection;
		}

		// Token: 0x0601B7F2 RID: 112626
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericAttributeCollection_SetActiveAttribute_28(HandleRef pThis, int attribute, int component);

		/// <summary>
		/// Set the scalar attribute to be processed. -1 means module.
		/// \pre not_empty: !IsEmpty()
		/// \pre valid_attribute: attribute&gt;=0 &amp;&amp; attribute&lt;GetNumberOfAttributes()
		/// \pre valid_component: component&gt;=-1 &amp;&amp;
		/// component&lt;GetAttribute(attribute)-&gt;GetNumberOfComponents()
		/// \post is_set: GetActiveAttribute()==attribute &amp;&amp;
		/// GetActiveComponent()==component
		/// </summary>
		// Token: 0x0601B7F3 RID: 112627 RVA: 0x00267C6F File Offset: 0x00265E6F
		public void SetActiveAttribute(int attribute, int component)
		{
			vtkGenericAttributeCollection.vtkGenericAttributeCollection_SetActiveAttribute_28(base.GetCppThis(), attribute, component);
		}

		// Token: 0x0601B7F4 RID: 112628
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericAttributeCollection_SetAttributesToInterpolate_29(HandleRef pThis, int size, IntPtr attributes);

		/// <summary>
		/// Set the attributes to interpolate.
		/// \pre not_empty: !IsEmpty()
		/// \pre positive_size: size&gt;=0
		/// \pre valid_attributes: size&gt;0 implies attributes!=0
		/// \pre valid_attributes_contents: attributes!=0 implies
		/// !HasAttributes(size,attributes,GetActiveAttribute())
		/// \post is_set: (GetNumberOfAttributesToInterpolate()==size)&amp;&amp;
		/// (GetAttributesToInterpolate()==attributes)
		/// </summary>
		// Token: 0x0601B7F5 RID: 112629 RVA: 0x00267C80 File Offset: 0x00265E80
		public void SetAttributesToInterpolate(int size, IntPtr attributes)
		{
			vtkGenericAttributeCollection.vtkGenericAttributeCollection_SetAttributesToInterpolate_29(base.GetCppThis(), size, attributes);
		}

		// Token: 0x0601B7F6 RID: 112630
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericAttributeCollection_SetAttributesToInterpolateToAll_30(HandleRef pThis);

		/// <summary>
		/// Set the attributes to interpolate.
		/// \pre not_empty: !IsEmpty()
		/// \pre positive_size: size&gt;=0
		/// \pre valid_attributes: size&gt;0 implies attributes!=0
		/// \pre valid_attributes_contents: attributes!=0 implies
		/// !HasAttributes(size,attributes,GetActiveAttribute())
		/// \post is_set: (GetNumberOfAttributesToInterpolate()==size)&amp;&amp;
		/// (GetAttributesToInterpolate()==attributes)
		/// </summary>
		// Token: 0x0601B7F7 RID: 112631 RVA: 0x00267C91 File Offset: 0x00265E91
		public void SetAttributesToInterpolateToAll()
		{
			vtkGenericAttributeCollection.vtkGenericAttributeCollection_SetAttributesToInterpolateToAll_30(base.GetCppThis());
		}

		// Token: 0x0601B7F8 RID: 112632
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericAttributeCollection_ShallowCopy_31(HandleRef pThis, HandleRef other);

		/// <summary>
		/// Copy, via reference counting, the other attribute array.
		/// \pre other_exists: other!=0
		/// \pre not_self: other!=this
		/// \post same_size: GetNumberOfAttributes()==other-&gt;GetNumberOfAttributes()
		/// </summary>
		// Token: 0x0601B7F9 RID: 112633 RVA: 0x00267CA0 File Offset: 0x00265EA0
		public void ShallowCopy(vtkGenericAttributeCollection other)
		{
			vtkGenericAttributeCollection.vtkGenericAttributeCollection_ShallowCopy_31(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D8A RID: 7562
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericAttributeCollection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D8B RID: 7563
		public new static readonly string MRClassNameKey = "class vtkGenericAttributeCollection";
	}
}
