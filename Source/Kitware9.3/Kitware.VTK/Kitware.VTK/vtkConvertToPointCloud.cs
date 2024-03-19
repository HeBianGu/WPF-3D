using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkConvertToPointCloud
	/// </summary>
	/// <remarks>
	///    Convert any dataset to a point cloud
	///
	/// This class convert any input dataset into a polydata point cloud
	/// containing the same points and point data and either no cells, a single poly vertex cell
	/// or as many vertex cell as they are points.
	///
	/// </remarks>
	// Token: 0x02000435 RID: 1077
	public class vtkConvertToPointCloud : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C9AE RID: 51630 RVA: 0x00118BD0 File Offset: 0x00116DD0
		static vtkConvertToPointCloud()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkConvertToPointCloud.MRClassNameKey, Type.GetType("Kitware.VTK.vtkConvertToPointCloud"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C9AF RID: 51631 RVA: 0x00118BF8 File Offset: 0x00116DF8
		public vtkConvertToPointCloud(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C9B0 RID: 51632
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConvertToPointCloud_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C9B1 RID: 51633 RVA: 0x00118C08 File Offset: 0x00116E08
		public new static vtkConvertToPointCloud New()
		{
			vtkConvertToPointCloud result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConvertToPointCloud.vtkConvertToPointCloud_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConvertToPointCloud)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C9B2 RID: 51634 RVA: 0x00118C5C File Offset: 0x00116E5C
		public vtkConvertToPointCloud() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkConvertToPointCloud.vtkConvertToPointCloud_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C9B3 RID: 51635 RVA: 0x00118CA0 File Offset: 0x00116EA0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C9B4 RID: 51636
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConvertToPointCloud_GetCellGenerationMode_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the cell generation mode.
		/// Available modes are:
		/// - NO_CELLS:
		/// No cells are generated
		/// - POLYVERTEX_CELL:
		/// A single polyvertex cell is generated (default)
		/// - VERTEX_CELLS:
		/// One vertex cell by point, not efficient to generate
		/// </summary>
		// Token: 0x0600C9B5 RID: 51637 RVA: 0x00118CAC File Offset: 0x00116EAC
		public virtual int GetCellGenerationMode()
		{
			return vtkConvertToPointCloud.vtkConvertToPointCloud_GetCellGenerationMode_01(base.GetCppThis());
		}

		// Token: 0x0600C9B6 RID: 51638
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkConvertToPointCloud_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C9B7 RID: 51639 RVA: 0x00118CCC File Offset: 0x00116ECC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkConvertToPointCloud.vtkConvertToPointCloud_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600C9B8 RID: 51640
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkConvertToPointCloud_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C9B9 RID: 51641 RVA: 0x00118CEC File Offset: 0x00116EEC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkConvertToPointCloud.vtkConvertToPointCloud_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600C9BA RID: 51642
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConvertToPointCloud_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C9BB RID: 51643 RVA: 0x00118D08 File Offset: 0x00116F08
		public override int IsA(string type)
		{
			return vtkConvertToPointCloud.vtkConvertToPointCloud_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600C9BC RID: 51644
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConvertToPointCloud_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C9BD RID: 51645 RVA: 0x00118D28 File Offset: 0x00116F28
		public new static int IsTypeOf(string type)
		{
			return vtkConvertToPointCloud.vtkConvertToPointCloud_IsTypeOf_05(type);
		}

		// Token: 0x0600C9BE RID: 51646
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConvertToPointCloud_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C9BF RID: 51647 RVA: 0x00118D44 File Offset: 0x00116F44
		public new vtkConvertToPointCloud NewInstance()
		{
			vtkConvertToPointCloud result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConvertToPointCloud.vtkConvertToPointCloud_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConvertToPointCloud)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C9C0 RID: 51648
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConvertToPointCloud_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C9C1 RID: 51649 RVA: 0x00118DA0 File Offset: 0x00116FA0
		public new static vtkConvertToPointCloud SafeDownCast(vtkObjectBase o)
		{
			vtkConvertToPointCloud vtkConvertToPointCloud = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConvertToPointCloud.vtkConvertToPointCloud_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkConvertToPointCloud = (vtkConvertToPointCloud)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkConvertToPointCloud.Register(null);
				}
			}
			return vtkConvertToPointCloud;
		}

		// Token: 0x0600C9C2 RID: 51650
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvertToPointCloud_SetCellGenerationMode_09(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the cell generation mode.
		/// Available modes are:
		/// - NO_CELLS:
		/// No cells are generated
		/// - POLYVERTEX_CELL:
		/// A single polyvertex cell is generated (default)
		/// - VERTEX_CELLS:
		/// One vertex cell by point, not efficient to generate
		/// </summary>
		// Token: 0x0600C9C3 RID: 51651 RVA: 0x00118E1F File Offset: 0x0011701F
		public virtual void SetCellGenerationMode(int _arg)
		{
			vtkConvertToPointCloud.vtkConvertToPointCloud_SetCellGenerationMode_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EF3 RID: 3827
		public new const string MRFullTypeName = "Kitware.VTK.vtkConvertToPointCloud";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EF4 RID: 3828
		public new static readonly string MRClassNameKey = "class vtkConvertToPointCloud";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000436 RID: 1078
		public enum CellGeneration
		{
			/// <summary>enum member</summary>
			// Token: 0x04000EF6 RID: 3830
			NO_CELLS,
			/// <summary>enum member</summary>
			// Token: 0x04000EF7 RID: 3831
			POLYVERTEX_CELL,
			/// <summary>enum member</summary>
			// Token: 0x04000EF8 RID: 3832
			VERTEX_CELLS
		}
	}
}
