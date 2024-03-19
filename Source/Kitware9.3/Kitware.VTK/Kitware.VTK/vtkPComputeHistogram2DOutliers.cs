using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPComputeHistogram2DOutliers
	/// </summary>
	/// <remarks>
	///    extract outlier rows from
	///  a vtkTable based on input 2D histograms, in parallel.
	///
	///
	///  This class does exactly the same this as vtkComputeHistogram2DOutliers,
	///  but does it in a multi-process environment.  After each node
	///  computes their own local outliers, class does an AllGather
	///  that distributes the outliers to every node.  This could probably just
	///  be a Gather onto the root node instead.
	///
	///  After this operation, the row selection will only contain local row ids,
	///  since I'm not sure how to deal with distributed ids.
	///
	/// </remarks>
	/// <seealso>
	///
	///  vtkComputeHistogram2DOutliers
	///
	/// @par Thanks:
	///  Developed by David Feng at Sandia National Laboratories
	///             ------------------------------------------------------------------------------
	/// </seealso>
	// Token: 0x02000471 RID: 1137
	public class vtkPComputeHistogram2DOutliers : vtkComputeHistogram2DOutliers
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D22A RID: 53802 RVA: 0x00124837 File Offset: 0x00122A37
		static vtkPComputeHistogram2DOutliers()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPComputeHistogram2DOutliers.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPComputeHistogram2DOutliers"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D22B RID: 53803 RVA: 0x0012485F File Offset: 0x00122A5F
		public vtkPComputeHistogram2DOutliers(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D22C RID: 53804
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPComputeHistogram2DOutliers_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D22D RID: 53805 RVA: 0x00124870 File Offset: 0x00122A70
		public new static vtkPComputeHistogram2DOutliers New()
		{
			vtkPComputeHistogram2DOutliers result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPComputeHistogram2DOutliers.vtkPComputeHistogram2DOutliers_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPComputeHistogram2DOutliers)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D22E RID: 53806 RVA: 0x001248C4 File Offset: 0x00122AC4
		public vtkPComputeHistogram2DOutliers() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPComputeHistogram2DOutliers.vtkPComputeHistogram2DOutliers_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D22F RID: 53807 RVA: 0x00124908 File Offset: 0x00122B08
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D230 RID: 53808
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPComputeHistogram2DOutliers_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D231 RID: 53809 RVA: 0x00124914 File Offset: 0x00122B14
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPComputeHistogram2DOutliers.vtkPComputeHistogram2DOutliers_GetController_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		// Token: 0x0600D232 RID: 53810
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPComputeHistogram2DOutliers_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D233 RID: 53811 RVA: 0x00124984 File Offset: 0x00122B84
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPComputeHistogram2DOutliers.vtkPComputeHistogram2DOutliers_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600D234 RID: 53812
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPComputeHistogram2DOutliers_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D235 RID: 53813 RVA: 0x001249A4 File Offset: 0x00122BA4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPComputeHistogram2DOutliers.vtkPComputeHistogram2DOutliers_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600D236 RID: 53814
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPComputeHistogram2DOutliers_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D237 RID: 53815 RVA: 0x001249C0 File Offset: 0x00122BC0
		public override int IsA(string type)
		{
			return vtkPComputeHistogram2DOutliers.vtkPComputeHistogram2DOutliers_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600D238 RID: 53816
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPComputeHistogram2DOutliers_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D239 RID: 53817 RVA: 0x001249E0 File Offset: 0x00122BE0
		public new static int IsTypeOf(string type)
		{
			return vtkPComputeHistogram2DOutliers.vtkPComputeHistogram2DOutliers_IsTypeOf_05(type);
		}

		// Token: 0x0600D23A RID: 53818
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPComputeHistogram2DOutliers_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D23B RID: 53819 RVA: 0x001249FC File Offset: 0x00122BFC
		public new vtkPComputeHistogram2DOutliers NewInstance()
		{
			vtkPComputeHistogram2DOutliers result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPComputeHistogram2DOutliers.vtkPComputeHistogram2DOutliers_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPComputeHistogram2DOutliers)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D23C RID: 53820
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPComputeHistogram2DOutliers_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D23D RID: 53821 RVA: 0x00124A58 File Offset: 0x00122C58
		public new static vtkPComputeHistogram2DOutliers SafeDownCast(vtkObjectBase o)
		{
			vtkPComputeHistogram2DOutliers vtkPComputeHistogram2DOutliers = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPComputeHistogram2DOutliers.vtkPComputeHistogram2DOutliers_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPComputeHistogram2DOutliers = (vtkPComputeHistogram2DOutliers)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPComputeHistogram2DOutliers.Register(null);
				}
			}
			return vtkPComputeHistogram2DOutliers;
		}

		// Token: 0x0600D23E RID: 53822
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPComputeHistogram2DOutliers_SetController_09(HandleRef pThis, HandleRef arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D23F RID: 53823 RVA: 0x00124AD8 File Offset: 0x00122CD8
		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkPComputeHistogram2DOutliers.vtkPComputeHistogram2DOutliers_SetController_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F86 RID: 3974
		public new const string MRFullTypeName = "Kitware.VTK.vtkPComputeHistogram2DOutliers";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F87 RID: 3975
		public new static readonly string MRClassNameKey = "class vtkPComputeHistogram2DOutliers";
	}
}
