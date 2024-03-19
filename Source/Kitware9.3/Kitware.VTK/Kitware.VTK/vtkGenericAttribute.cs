using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGenericAttribute
	/// </summary>
	/// <remarks>
	///    abstract class defined API for attribute data
	///
	/// vtkGenericAttribute is an abstract class that defines an API for attribute
	/// data. Attribute data is data associated with the topology or geometry of
	/// a dataset (i.e., points, cells, etc.). vtkGenericAttribute is part of the
	/// adaptor framework (see GenericFiltering/README.html).
	///
	/// vtkGenericAttribute provides a more general interface to attribute data
	/// than its counterpart vtkDataArray (which assumes a linear, contiguous
	/// array). It adopts an iterator interface, and allows attributes to be
	/// associated with points, edges, faces, or edges.
	/// </remarks>
	// Token: 0x02000A4A RID: 2634
	public abstract class vtkGenericAttribute : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B781 RID: 112513 RVA: 0x0026727F File Offset: 0x0026547F
		static vtkGenericAttribute()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericAttribute.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericAttribute"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B782 RID: 112514 RVA: 0x002672A7 File Offset: 0x002654A7
		public vtkGenericAttribute(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B783 RID: 112515 RVA: 0x002672B5 File Offset: 0x002654B5
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B784 RID: 112516
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericAttribute_DeepCopy_01(HandleRef pThis, HandleRef other);

		/// <summary>
		/// Recursive duplication of `other' in `this'.
		/// \pre other_exists: other!=0
		/// \pre not_self: other!=this
		/// </summary>
		// Token: 0x0601B785 RID: 112517 RVA: 0x002672C0 File Offset: 0x002654C0
		public virtual void DeepCopy(vtkGenericAttribute other)
		{
			vtkGenericAttribute.vtkGenericAttribute_DeepCopy_01(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}

		// Token: 0x0601B786 RID: 112518
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkGenericAttribute_GetActualMemorySize_02(HandleRef pThis);

		/// <summary>
		/// Size in kibibytes (1024 bytes) taken by the attribute.
		/// </summary>
		// Token: 0x0601B787 RID: 112519 RVA: 0x002672F0 File Offset: 0x002654F0
		public virtual uint GetActualMemorySize()
		{
			return vtkGenericAttribute.vtkGenericAttribute_GetActualMemorySize_02(base.GetCppThis());
		}

		// Token: 0x0601B788 RID: 112520
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAttribute_GetCentering_03(HandleRef pThis);

		/// <summary>
		/// Is the attribute centered either on points, cells or boundaries?
		/// \post valid_result: (result==vtkPointCentered)||(result==vtkCellCentered)
		/// </summary>
		// Token: 0x0601B789 RID: 112521 RVA: 0x00267310 File Offset: 0x00265510
		public virtual int GetCentering()
		{
			return vtkGenericAttribute.vtkGenericAttribute_GetCentering_03(base.GetCppThis());
		}

		// Token: 0x0601B78A RID: 112522
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericAttribute_GetComponent_04(HandleRef pThis, int i, HandleRef c, IntPtr values);

		/// <summary>
		/// Put component `i' of the attribute at all points of cell `c' in `values'.
		/// \pre valid_component: (i&gt;=0) &amp;&amp; (i&lt;GetNumberOfComponents())
		/// \pre c_exists: c!=0
		/// \pre c_valid: !c-&gt;IsAtEnd()
		/// \pre values_exist: values!=0
		/// \pre valid_values: sizeof(values)&gt;=c-&gt;GetCell()-&gt;GetNumberOfPoints()
		/// </summary>
		// Token: 0x0601B78B RID: 112523 RVA: 0x00267330 File Offset: 0x00265530
		public virtual void GetComponent(int i, vtkGenericCellIterator c, IntPtr values)
		{
			vtkGenericAttribute.vtkGenericAttribute_GetComponent_04(base.GetCppThis(), i, (c == null) ? default(HandleRef) : c.GetCppThis(), values);
		}

		// Token: 0x0601B78C RID: 112524
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGenericAttribute_GetComponent_05(HandleRef pThis, int i, HandleRef p);

		/// <summary>
		/// Value of the component `i' of the attribute at position `p'.
		/// \pre valid_component: (i&gt;=0) &amp;&amp; (i&lt;GetNumberOfComponents())
		/// \pre p_exists: p!=0
		/// \pre p_valid: !p-&gt;IsAtEnd()
		/// </summary>
		// Token: 0x0601B78D RID: 112525 RVA: 0x00267364 File Offset: 0x00265564
		public virtual double GetComponent(int i, vtkGenericPointIterator p)
		{
			return vtkGenericAttribute.vtkGenericAttribute_GetComponent_05(base.GetCppThis(), i, (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0601B78E RID: 112526
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAttribute_GetComponentType_06(HandleRef pThis);

		/// <summary>
		/// Type of the components of the attribute: int, float, double
		/// \post valid_result: (result==VTK_BIT)           ||(result==VTK_CHAR)
		/// ||(result==VTK_UNSIGNED_CHAR) ||(result==VTK_SHORT)
		/// ||(result==VTK_UNSIGNED_SHORT)||(result==VTK_INT)
		/// ||(result==VTK_UNSIGNED_INT)  ||(result==VTK_LONG)
		/// ||(result==VTK_UNSIGNED_LONG) ||(result==VTK_FLOAT)
		/// ||(result==VTK_DOUBLE)        ||(result==VTK_ID_TYPE)
		/// </summary>
		// Token: 0x0601B78F RID: 112527 RVA: 0x0026739C File Offset: 0x0026559C
		public virtual int GetComponentType()
		{
			return vtkGenericAttribute.vtkGenericAttribute_GetComponentType_06(base.GetCppThis());
		}

		// Token: 0x0601B790 RID: 112528
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGenericAttribute_GetMaxNorm_07(HandleRef pThis);

		/// <summary>
		/// Return the maximum euclidean norm for the tuples.
		/// \post positive_result: result&gt;=0
		/// </summary>
		// Token: 0x0601B791 RID: 112529 RVA: 0x002673BC File Offset: 0x002655BC
		public virtual double GetMaxNorm()
		{
			return vtkGenericAttribute.vtkGenericAttribute_GetMaxNorm_07(base.GetCppThis());
		}

		// Token: 0x0601B792 RID: 112530
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericAttribute_GetName_08(HandleRef pThis);

		/// <summary>
		/// Name of the attribute. (e.g. "velocity")
		/// \post result_may_not_exist: result!=0 || result==0
		/// </summary>
		// Token: 0x0601B793 RID: 112531 RVA: 0x002673DC File Offset: 0x002655DC
		public virtual string GetName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGenericAttribute.vtkGenericAttribute_GetName_08(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601B794 RID: 112532
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAttribute_GetNumberOfComponents_09(HandleRef pThis);

		/// <summary>
		/// Dimension of the attribute. (1 for scalar, 3 for velocity)
		/// \post positive_result: result&gt;=0
		/// \post GetType()==VTK_SCALARS implies result==1
		/// \post (GetType()==VTK_VECTORS||(GetType()==VTK_NORMALS)||(GetType()==VTK_TCOORDS) implies
		/// result==3 \post GetType()==VTK_TENSORS implies result==6
		/// </summary>
		// Token: 0x0601B795 RID: 112533 RVA: 0x00267418 File Offset: 0x00265618
		public virtual int GetNumberOfComponents()
		{
			return vtkGenericAttribute.vtkGenericAttribute_GetNumberOfComponents_09(base.GetCppThis());
		}

		// Token: 0x0601B796 RID: 112534
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericAttribute_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B797 RID: 112535 RVA: 0x00267438 File Offset: 0x00265638
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGenericAttribute.vtkGenericAttribute_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x0601B798 RID: 112536
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericAttribute_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B799 RID: 112537 RVA: 0x00267458 File Offset: 0x00265658
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGenericAttribute.vtkGenericAttribute_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x0601B79A RID: 112538
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericAttribute_GetRange_12(HandleRef pThis, int component);

		/// <summary>
		/// Range of the attribute component `component'. If `component'==-1, it
		/// returns the range of the magnitude (euclidean norm).
		/// It returns double, even if GetType()==VTK_INT.
		/// NOT THREAD SAFE
		/// \pre valid_component: (component&gt;=-1)&amp;&amp;(component&lt;GetNumberOfComponents())
		/// \post result_exists: result!=0
		/// </summary>
		// Token: 0x0601B79B RID: 112539 RVA: 0x00267474 File Offset: 0x00265674
		public virtual IntPtr GetRange(int component)
		{
			return vtkGenericAttribute.vtkGenericAttribute_GetRange_12(base.GetCppThis(), component);
		}

		// Token: 0x0601B79C RID: 112540
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericAttribute_GetRange_13(HandleRef pThis, int component, IntPtr range);

		/// <summary>
		/// Range of the attribute component `component'. If `component'==-1, it
		/// returns the range of the magnitude (euclidean norm).
		/// THREAD SAFE
		/// \pre valid_component: (component&gt;=-1)&amp;&amp;(component&lt;GetNumberOfComponents())
		/// </summary>
		// Token: 0x0601B79D RID: 112541 RVA: 0x00267494 File Offset: 0x00265694
		public virtual void GetRange(int component, IntPtr range)
		{
			vtkGenericAttribute.vtkGenericAttribute_GetRange_13(base.GetCppThis(), component, range);
		}

		// Token: 0x0601B79E RID: 112542
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericAttribute_GetSize_14(HandleRef pThis);

		/// <summary>
		/// Number of tuples.
		/// \post valid_result: result&gt;=0
		/// </summary>
		// Token: 0x0601B79F RID: 112543 RVA: 0x002674A8 File Offset: 0x002656A8
		public virtual long GetSize()
		{
			return vtkGenericAttribute.vtkGenericAttribute_GetSize_14(base.GetCppThis());
		}

		// Token: 0x0601B7A0 RID: 112544
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericAttribute_GetTuple_15(HandleRef pThis, HandleRef c);

		/// <summary>
		/// Attribute at all points of cell `c'.
		/// \pre c_exists: c!=0
		/// \pre c_valid: !c-&gt;IsAtEnd()
		/// \post result_exists: result!=0
		/// \post valid_result: sizeof(result)==GetNumberOfComponents()*c-&gt;GetCell()-&gt;GetNumberOfPoints()
		/// </summary>
		// Token: 0x0601B7A1 RID: 112545 RVA: 0x002674C8 File Offset: 0x002656C8
		public virtual IntPtr GetTuple(vtkGenericAdaptorCell c)
		{
			return vtkGenericAttribute.vtkGenericAttribute_GetTuple_15(base.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis());
		}

		// Token: 0x0601B7A2 RID: 112546
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericAttribute_GetTuple_16(HandleRef pThis, HandleRef c, IntPtr tuple);

		/// <summary>
		/// Put attribute at all points of cell `c' in `tuple'.
		/// \pre c_exists: c!=0
		/// \pre c_valid: !c-&gt;IsAtEnd()
		/// \pre tuple_exists: tuple!=0
		/// \pre valid_tuple: sizeof(tuple)&gt;=GetNumberOfComponents()*c-&gt;GetCell()-&gt;GetNumberOfPoints()
		/// </summary>
		// Token: 0x0601B7A3 RID: 112547 RVA: 0x002674FC File Offset: 0x002656FC
		public virtual void GetTuple(vtkGenericAdaptorCell c, IntPtr tuple)
		{
			vtkGenericAttribute.vtkGenericAttribute_GetTuple_16(base.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis(), tuple);
		}

		// Token: 0x0601B7A4 RID: 112548
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericAttribute_GetTuple_17(HandleRef pThis, HandleRef c);

		/// <summary>
		/// Attribute at all points of cell `c'.
		/// \pre c_exists: c!=0
		/// \pre c_valid: !c-&gt;IsAtEnd()
		/// \post result_exists: result!=0
		/// \post valid_result: sizeof(result)==GetNumberOfComponents()*c-&gt;GetCell()-&gt;GetNumberOfPoints()
		/// </summary>
		// Token: 0x0601B7A5 RID: 112549 RVA: 0x0026752C File Offset: 0x0026572C
		public virtual IntPtr GetTuple(vtkGenericCellIterator c)
		{
			return vtkGenericAttribute.vtkGenericAttribute_GetTuple_17(base.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis());
		}

		// Token: 0x0601B7A6 RID: 112550
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericAttribute_GetTuple_18(HandleRef pThis, HandleRef c, IntPtr tuple);

		/// <summary>
		/// Put attribute at all points of cell `c' in `tuple'.
		/// \pre c_exists: c!=0
		/// \pre c_valid: !c-&gt;IsAtEnd()
		/// \pre tuple_exists: tuple!=0
		/// \pre valid_tuple: sizeof(tuple)&gt;=GetNumberOfComponents()*c-&gt;GetCell()-&gt;GetNumberOfPoints()
		/// </summary>
		// Token: 0x0601B7A7 RID: 112551 RVA: 0x00267560 File Offset: 0x00265760
		public virtual void GetTuple(vtkGenericCellIterator c, IntPtr tuple)
		{
			vtkGenericAttribute.vtkGenericAttribute_GetTuple_18(base.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis(), tuple);
		}

		// Token: 0x0601B7A8 RID: 112552
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericAttribute_GetTuple_19(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Value of the attribute at position `p'.
		/// \pre p_exists: p!=0
		/// \pre p_valid: !p-&gt;IsAtEnd()
		/// \post result_exists: result!=0
		/// \post valid_result_size: sizeof(result)==GetNumberOfComponents()
		/// </summary>
		// Token: 0x0601B7A9 RID: 112553 RVA: 0x00267590 File Offset: 0x00265790
		public virtual IntPtr GetTuple(vtkGenericPointIterator p)
		{
			return vtkGenericAttribute.vtkGenericAttribute_GetTuple_19(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0601B7AA RID: 112554
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericAttribute_GetTuple_20(HandleRef pThis, HandleRef p, IntPtr tuple);

		/// <summary>
		/// Put the value of the attribute at position `p' into `tuple'.
		/// \pre p_exists: p!=0
		/// \pre p_valid: !p-&gt;IsAtEnd()
		/// \pre tuple_exists: tuple!=0
		/// \pre valid_tuple_size: sizeof(tuple)&gt;=GetNumberOfComponents()
		/// </summary>
		// Token: 0x0601B7AB RID: 112555 RVA: 0x002675C4 File Offset: 0x002657C4
		public virtual void GetTuple(vtkGenericPointIterator p, IntPtr tuple)
		{
			vtkGenericAttribute.vtkGenericAttribute_GetTuple_20(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis(), tuple);
		}

		// Token: 0x0601B7AC RID: 112556
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAttribute_GetType_21(HandleRef pThis);

		/// <summary>
		/// Type of the attribute: scalar, vector, normal, texture coordinate, tensor
		/// \post valid_result: (result==vtkDataSetAttributes::SCALARS)
		/// ||(result==vtkDataSetAttributes::VECTORS)
		/// ||(result==vtkDataSetAttributes::NORMALS)
		/// ||(result==vtkDataSetAttributes::TCOORDS)
		/// ||(result==vtkDataSetAttributes::TENSORS)
		/// </summary>
		// Token: 0x0601B7AD RID: 112557 RVA: 0x002675F4 File Offset: 0x002657F4
		public virtual int GetTypeWrapper()
		{
			return vtkGenericAttribute.vtkGenericAttribute_GetType_21(base.GetCppThis());
		}

		// Token: 0x0601B7AE RID: 112558
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAttribute_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B7AF RID: 112559 RVA: 0x00267614 File Offset: 0x00265814
		public override int IsA(string type)
		{
			return vtkGenericAttribute.vtkGenericAttribute_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x0601B7B0 RID: 112560
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAttribute_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B7B1 RID: 112561 RVA: 0x00267634 File Offset: 0x00265834
		public new static int IsTypeOf(string type)
		{
			return vtkGenericAttribute.vtkGenericAttribute_IsTypeOf_23(type);
		}

		// Token: 0x0601B7B2 RID: 112562
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericAttribute_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B7B3 RID: 112563 RVA: 0x00267650 File Offset: 0x00265850
		public new vtkGenericAttribute NewInstance()
		{
			vtkGenericAttribute result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericAttribute.vtkGenericAttribute_NewInstance_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericAttribute)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B7B4 RID: 112564
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericAttribute_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B7B5 RID: 112565 RVA: 0x002676AC File Offset: 0x002658AC
		public new static vtkGenericAttribute SafeDownCast(vtkObjectBase o)
		{
			vtkGenericAttribute vtkGenericAttribute = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericAttribute.vtkGenericAttribute_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601B7B6 RID: 112566
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericAttribute_ShallowCopy_26(HandleRef pThis, HandleRef other);

		/// <summary>
		/// Update `this' using fields of `other'.
		/// \pre other_exists: other!=0
		/// \pre not_self: other!=this
		/// </summary>
		// Token: 0x0601B7B7 RID: 112567 RVA: 0x0026772C File Offset: 0x0026592C
		public virtual void ShallowCopy(vtkGenericAttribute other)
		{
			vtkGenericAttribute.vtkGenericAttribute_ShallowCopy_26(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D88 RID: 7560
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericAttribute";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D89 RID: 7561
		public new static readonly string MRClassNameKey = "class vtkGenericAttribute";
	}
}
