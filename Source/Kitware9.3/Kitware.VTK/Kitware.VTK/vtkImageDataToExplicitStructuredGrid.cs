using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageDataToExplicitStructuredGrid
	/// </summary>
	/// <remarks>
	///    Filter which converts a 3D image data into an explicit structured grid.
	/// </remarks>
	// Token: 0x02000973 RID: 2419
	public class vtkImageDataToExplicitStructuredGrid : vtkExplicitStructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060193A6 RID: 103334 RVA: 0x002324EF File Offset: 0x002306EF
		static vtkImageDataToExplicitStructuredGrid()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageDataToExplicitStructuredGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageDataToExplicitStructuredGrid"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060193A7 RID: 103335 RVA: 0x00232517 File Offset: 0x00230717
		public vtkImageDataToExplicitStructuredGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060193A8 RID: 103336
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDataToExplicitStructuredGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060193A9 RID: 103337 RVA: 0x00232528 File Offset: 0x00230728
		public new static vtkImageDataToExplicitStructuredGrid New()
		{
			vtkImageDataToExplicitStructuredGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDataToExplicitStructuredGrid.vtkImageDataToExplicitStructuredGrid_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDataToExplicitStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060193AA RID: 103338 RVA: 0x0023257C File Offset: 0x0023077C
		public vtkImageDataToExplicitStructuredGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageDataToExplicitStructuredGrid.vtkImageDataToExplicitStructuredGrid_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060193AB RID: 103339 RVA: 0x002325C0 File Offset: 0x002307C0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060193AC RID: 103340
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageDataToExplicitStructuredGrid_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060193AD RID: 103341 RVA: 0x002325CC File Offset: 0x002307CC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageDataToExplicitStructuredGrid.vtkImageDataToExplicitStructuredGrid_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060193AE RID: 103342
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageDataToExplicitStructuredGrid_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060193AF RID: 103343 RVA: 0x002325EC File Offset: 0x002307EC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageDataToExplicitStructuredGrid.vtkImageDataToExplicitStructuredGrid_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060193B0 RID: 103344
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDataToExplicitStructuredGrid_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060193B1 RID: 103345 RVA: 0x00232608 File Offset: 0x00230808
		public override int IsA(string type)
		{
			return vtkImageDataToExplicitStructuredGrid.vtkImageDataToExplicitStructuredGrid_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x060193B2 RID: 103346
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDataToExplicitStructuredGrid_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060193B3 RID: 103347 RVA: 0x00232628 File Offset: 0x00230828
		public new static int IsTypeOf(string type)
		{
			return vtkImageDataToExplicitStructuredGrid.vtkImageDataToExplicitStructuredGrid_IsTypeOf_04(type);
		}

		// Token: 0x060193B4 RID: 103348
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDataToExplicitStructuredGrid_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060193B5 RID: 103349 RVA: 0x00232644 File Offset: 0x00230844
		public new vtkImageDataToExplicitStructuredGrid NewInstance()
		{
			vtkImageDataToExplicitStructuredGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDataToExplicitStructuredGrid.vtkImageDataToExplicitStructuredGrid_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDataToExplicitStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060193B6 RID: 103350
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDataToExplicitStructuredGrid_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060193B7 RID: 103351 RVA: 0x002326A0 File Offset: 0x002308A0
		public new static vtkImageDataToExplicitStructuredGrid SafeDownCast(vtkObjectBase o)
		{
			vtkImageDataToExplicitStructuredGrid vtkImageDataToExplicitStructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDataToExplicitStructuredGrid.vtkImageDataToExplicitStructuredGrid_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageDataToExplicitStructuredGrid = (vtkImageDataToExplicitStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageDataToExplicitStructuredGrid.Register(null);
				}
			}
			return vtkImageDataToExplicitStructuredGrid;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B9F RID: 7071
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageDataToExplicitStructuredGrid";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BA0 RID: 7072
		public new static readonly string MRClassNameKey = "class vtkImageDataToExplicitStructuredGrid";
	}
}
