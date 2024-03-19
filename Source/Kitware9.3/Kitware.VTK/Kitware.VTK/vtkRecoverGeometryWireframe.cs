using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRecoverGeometryWireframe
	/// </summary>
	/// <remarks>
	///    Get corrected wireframe from tessellated facets
	///
	/// This filter create an edge mask that is used at render time to ignore the
	/// rendering of specific edges in wireframe mode. For that it checks a cell attribute
	/// so that each adjacent cells having the same attribute value will not display an
	/// edge between them.
	///
	/// The main usage of this filter is at the output of vtkDataSetSurfaceFilter or
	/// vtkGeometryFilter, when we are subdividing non-linear cells but we still want to
	/// visualize the edges of the original cells. In this case the cell attribute
	/// will usually be the original cell id values.
	///
	/// @warning As the edge flag mechanism does not allow to specify a single edge
	/// from a point the filter might duplicate some points, so topology
	/// is not preserved.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkDataSetSurfaceFilter
	/// </seealso>
	// Token: 0x02000910 RID: 2320
	public class vtkRecoverGeometryWireframe : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060180C4 RID: 98500 RVA: 0x0021A66F File Offset: 0x0021886F
		static vtkRecoverGeometryWireframe()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRecoverGeometryWireframe.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRecoverGeometryWireframe"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060180C5 RID: 98501 RVA: 0x0021A697 File Offset: 0x00218897
		public vtkRecoverGeometryWireframe(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060180C6 RID: 98502
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRecoverGeometryWireframe_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060180C7 RID: 98503 RVA: 0x0021A6A8 File Offset: 0x002188A8
		public new static vtkRecoverGeometryWireframe New()
		{
			vtkRecoverGeometryWireframe result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRecoverGeometryWireframe.vtkRecoverGeometryWireframe_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRecoverGeometryWireframe)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060180C8 RID: 98504 RVA: 0x0021A6FC File Offset: 0x002188FC
		public vtkRecoverGeometryWireframe() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRecoverGeometryWireframe.vtkRecoverGeometryWireframe_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060180C9 RID: 98505 RVA: 0x0021A740 File Offset: 0x00218940
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060180CA RID: 98506
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkRecoverGeometryWireframe_GetCellIdsAttribute_01(HandleRef pThis);

		/// <summary>
		/// Get/Set the cell attribute name that will be used to discriminate edges that
		/// should be kept from edges that shouldn't. This array should be a vtkIdType
		/// array.
		///
		/// Default is empty.
		/// </summary>
		// Token: 0x060180CB RID: 98507 RVA: 0x0021A74C File Offset: 0x0021894C
		public virtual string GetCellIdsAttribute()
		{
			return vtkRecoverGeometryWireframe.vtkRecoverGeometryWireframe_GetCellIdsAttribute_01(base.GetCppThis());
		}

		// Token: 0x060180CC RID: 98508
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRecoverGeometryWireframe_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060180CD RID: 98509 RVA: 0x0021A76C File Offset: 0x0021896C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRecoverGeometryWireframe.vtkRecoverGeometryWireframe_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060180CE RID: 98510
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRecoverGeometryWireframe_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060180CF RID: 98511 RVA: 0x0021A78C File Offset: 0x0021898C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRecoverGeometryWireframe.vtkRecoverGeometryWireframe_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060180D0 RID: 98512
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRecoverGeometryWireframe_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060180D1 RID: 98513 RVA: 0x0021A7A8 File Offset: 0x002189A8
		public override int IsA(string type)
		{
			return vtkRecoverGeometryWireframe.vtkRecoverGeometryWireframe_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060180D2 RID: 98514
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRecoverGeometryWireframe_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060180D3 RID: 98515 RVA: 0x0021A7C8 File Offset: 0x002189C8
		public new static int IsTypeOf(string type)
		{
			return vtkRecoverGeometryWireframe.vtkRecoverGeometryWireframe_IsTypeOf_05(type);
		}

		// Token: 0x060180D4 RID: 98516
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRecoverGeometryWireframe_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060180D5 RID: 98517 RVA: 0x0021A7E4 File Offset: 0x002189E4
		public new vtkRecoverGeometryWireframe NewInstance()
		{
			vtkRecoverGeometryWireframe result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRecoverGeometryWireframe.vtkRecoverGeometryWireframe_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRecoverGeometryWireframe)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060180D6 RID: 98518
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRecoverGeometryWireframe_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060180D7 RID: 98519 RVA: 0x0021A840 File Offset: 0x00218A40
		public new static vtkRecoverGeometryWireframe SafeDownCast(vtkObjectBase o)
		{
			vtkRecoverGeometryWireframe vtkRecoverGeometryWireframe = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRecoverGeometryWireframe.vtkRecoverGeometryWireframe_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRecoverGeometryWireframe = (vtkRecoverGeometryWireframe)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRecoverGeometryWireframe.Register(null);
				}
			}
			return vtkRecoverGeometryWireframe;
		}

		// Token: 0x060180D8 RID: 98520
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRecoverGeometryWireframe_SetCellIdsAttribute_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the cell attribute name that will be used to discriminate edges that
		/// should be kept from edges that shouldn't. This array should be a vtkIdType
		/// array.
		///
		/// Default is empty.
		/// </summary>
		// Token: 0x060180D9 RID: 98521 RVA: 0x0021A8BF File Offset: 0x00218ABF
		public virtual void SetCellIdsAttribute(string _arg)
		{
			vtkRecoverGeometryWireframe.vtkRecoverGeometryWireframe_SetCellIdsAttribute_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001ACA RID: 6858
		public new const string MRFullTypeName = "Kitware.VTK.vtkRecoverGeometryWireframe";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001ACB RID: 6859
		public new static readonly string MRClassNameKey = "class vtkRecoverGeometryWireframe";
	}
}
