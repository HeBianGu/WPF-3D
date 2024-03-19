using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageToStructuredGrid
	/// a structured grid instance.
	///
	///
	/// A concrete instance of vtkStructuredGridAlgorithm which provides
	/// functionality for converting instances of vtkImageData to vtkStructuredGrid.
	/// </summary>
	// Token: 0x020009D5 RID: 2517
	public class vtkImageToStructuredGrid : vtkStructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A3BC RID: 107452 RVA: 0x00245FC8 File Offset: 0x002441C8
		static vtkImageToStructuredGrid()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageToStructuredGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageToStructuredGrid"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A3BD RID: 107453 RVA: 0x00245FF0 File Offset: 0x002441F0
		public vtkImageToStructuredGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A3BE RID: 107454
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageToStructuredGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A3BF RID: 107455 RVA: 0x00246000 File Offset: 0x00244200
		public new static vtkImageToStructuredGrid New()
		{
			vtkImageToStructuredGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageToStructuredGrid.vtkImageToStructuredGrid_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageToStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A3C0 RID: 107456 RVA: 0x00246054 File Offset: 0x00244254
		public vtkImageToStructuredGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageToStructuredGrid.vtkImageToStructuredGrid_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A3C1 RID: 107457 RVA: 0x00246098 File Offset: 0x00244298
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A3C2 RID: 107458
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageToStructuredGrid_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A3C3 RID: 107459 RVA: 0x002460A4 File Offset: 0x002442A4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageToStructuredGrid.vtkImageToStructuredGrid_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601A3C4 RID: 107460
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageToStructuredGrid_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A3C5 RID: 107461 RVA: 0x002460C4 File Offset: 0x002442C4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageToStructuredGrid.vtkImageToStructuredGrid_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601A3C6 RID: 107462
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToStructuredGrid_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A3C7 RID: 107463 RVA: 0x002460E0 File Offset: 0x002442E0
		public override int IsA(string type)
		{
			return vtkImageToStructuredGrid.vtkImageToStructuredGrid_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601A3C8 RID: 107464
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToStructuredGrid_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A3C9 RID: 107465 RVA: 0x00246100 File Offset: 0x00244300
		public new static int IsTypeOf(string type)
		{
			return vtkImageToStructuredGrid.vtkImageToStructuredGrid_IsTypeOf_04(type);
		}

		// Token: 0x0601A3CA RID: 107466
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageToStructuredGrid_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A3CB RID: 107467 RVA: 0x0024611C File Offset: 0x0024431C
		public new vtkImageToStructuredGrid NewInstance()
		{
			vtkImageToStructuredGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageToStructuredGrid.vtkImageToStructuredGrid_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageToStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A3CC RID: 107468
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageToStructuredGrid_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A3CD RID: 107469 RVA: 0x00246178 File Offset: 0x00244378
		public new static vtkImageToStructuredGrid SafeDownCast(vtkObjectBase o)
		{
			vtkImageToStructuredGrid vtkImageToStructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageToStructuredGrid.vtkImageToStructuredGrid_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageToStructuredGrid = (vtkImageToStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageToStructuredGrid.Register(null);
				}
			}
			return vtkImageToStructuredGrid;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C7A RID: 7290
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageToStructuredGrid";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C7B RID: 7291
		public new static readonly string MRClassNameKey = "class vtkImageToStructuredGrid";
	}
}
