using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractPiece
	///
	/// vtkExtractPiece returns the appropriate piece of each
	/// sub-dataset in the vtkCompositeDataSet.
	/// This filter can handle sub-datasets of type vtkImageData, vtkPolyData,
	/// vtkRectilinearGrid, vtkStructuredGrid, and vtkUnstructuredGrid; it does
	/// not handle sub-grids of type vtkCompositeDataSet.
	/// </summary>
	// Token: 0x0200046B RID: 1131
	public class vtkExtractPiece : vtkCompositeDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D1CA RID: 53706 RVA: 0x00123D48 File Offset: 0x00121F48
		static vtkExtractPiece()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractPiece.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractPiece"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D1CB RID: 53707 RVA: 0x00123D70 File Offset: 0x00121F70
		public vtkExtractPiece(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D1CC RID: 53708
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractPiece_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D1CD RID: 53709 RVA: 0x00123D80 File Offset: 0x00121F80
		public new static vtkExtractPiece New()
		{
			vtkExtractPiece result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractPiece.vtkExtractPiece_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractPiece)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D1CE RID: 53710 RVA: 0x00123DD4 File Offset: 0x00121FD4
		public vtkExtractPiece() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractPiece.vtkExtractPiece_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D1CF RID: 53711 RVA: 0x00123E18 File Offset: 0x00122018
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D1D0 RID: 53712
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractPiece_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D1D1 RID: 53713 RVA: 0x00123E24 File Offset: 0x00122024
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractPiece.vtkExtractPiece_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600D1D2 RID: 53714
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractPiece_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D1D3 RID: 53715 RVA: 0x00123E44 File Offset: 0x00122044
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractPiece.vtkExtractPiece_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600D1D4 RID: 53716
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractPiece_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D1D5 RID: 53717 RVA: 0x00123E60 File Offset: 0x00122060
		public override int IsA(string type)
		{
			return vtkExtractPiece.vtkExtractPiece_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600D1D6 RID: 53718
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractPiece_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D1D7 RID: 53719 RVA: 0x00123E80 File Offset: 0x00122080
		public new static int IsTypeOf(string type)
		{
			return vtkExtractPiece.vtkExtractPiece_IsTypeOf_04(type);
		}

		// Token: 0x0600D1D8 RID: 53720
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractPiece_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D1D9 RID: 53721 RVA: 0x00123E9C File Offset: 0x0012209C
		public new vtkExtractPiece NewInstance()
		{
			vtkExtractPiece result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractPiece.vtkExtractPiece_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractPiece)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D1DA RID: 53722
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractPiece_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D1DB RID: 53723 RVA: 0x00123EF8 File Offset: 0x001220F8
		public new static vtkExtractPiece SafeDownCast(vtkObjectBase o)
		{
			vtkExtractPiece vtkExtractPiece = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractPiece.vtkExtractPiece_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractPiece = (vtkExtractPiece)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractPiece.Register(null);
				}
			}
			return vtkExtractPiece;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F77 RID: 3959
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractPiece";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F78 RID: 3960
		public new static readonly string MRClassNameKey = "class vtkExtractPiece";
	}
}
