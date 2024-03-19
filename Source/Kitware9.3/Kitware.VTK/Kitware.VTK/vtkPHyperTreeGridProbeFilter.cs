using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPHyperTreeGridProbeFilter
	/// </summary>
	/// <remarks>
	///    probe a vtkHyperTreeGrid in parallel
	///
	/// Heavily modeled after the vtkPProbeFilter and vtkProbeFilter, this class
	///  is meant to be used to probe vtkHyperTreeGrid objects in parallel.
	///
	/// This filter works correctly only if the whole geometry dataset
	/// (that specify the point locations used to probe input) is present on all
	/// nodes.
	///
	/// Possible optimizations:
	/// - Enrich the parallelism logic allowing for both distributed sources and input/outputs
	/// </remarks>
	// Token: 0x02000507 RID: 1287
	public class vtkPHyperTreeGridProbeFilter : vtkHyperTreeGridProbeFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E754 RID: 59220 RVA: 0x0014230B File Offset: 0x0014050B
		static vtkPHyperTreeGridProbeFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPHyperTreeGridProbeFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPHyperTreeGridProbeFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E755 RID: 59221 RVA: 0x00142333 File Offset: 0x00140533
		public vtkPHyperTreeGridProbeFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E756 RID: 59222
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPHyperTreeGridProbeFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E757 RID: 59223 RVA: 0x00142344 File Offset: 0x00140544
		public new static vtkPHyperTreeGridProbeFilter New()
		{
			vtkPHyperTreeGridProbeFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPHyperTreeGridProbeFilter.vtkPHyperTreeGridProbeFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPHyperTreeGridProbeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E758 RID: 59224 RVA: 0x00142398 File Offset: 0x00140598
		public vtkPHyperTreeGridProbeFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPHyperTreeGridProbeFilter.vtkPHyperTreeGridProbeFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E759 RID: 59225 RVA: 0x001423DC File Offset: 0x001405DC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E75A RID: 59226
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPHyperTreeGridProbeFilter_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set and get the controller.
		/// </summary>
		// Token: 0x0600E75B RID: 59227 RVA: 0x001423E8 File Offset: 0x001405E8
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPHyperTreeGridProbeFilter.vtkPHyperTreeGridProbeFilter_GetController_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600E75C RID: 59228
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPHyperTreeGridProbeFilter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E75D RID: 59229 RVA: 0x00142458 File Offset: 0x00140658
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPHyperTreeGridProbeFilter.vtkPHyperTreeGridProbeFilter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600E75E RID: 59230
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPHyperTreeGridProbeFilter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E75F RID: 59231 RVA: 0x00142478 File Offset: 0x00140678
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPHyperTreeGridProbeFilter.vtkPHyperTreeGridProbeFilter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600E760 RID: 59232
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPHyperTreeGridProbeFilter_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E761 RID: 59233 RVA: 0x00142494 File Offset: 0x00140694
		public override int IsA(string type)
		{
			return vtkPHyperTreeGridProbeFilter.vtkPHyperTreeGridProbeFilter_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600E762 RID: 59234
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPHyperTreeGridProbeFilter_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E763 RID: 59235 RVA: 0x001424B4 File Offset: 0x001406B4
		public new static int IsTypeOf(string type)
		{
			return vtkPHyperTreeGridProbeFilter.vtkPHyperTreeGridProbeFilter_IsTypeOf_05(type);
		}

		// Token: 0x0600E764 RID: 59236
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPHyperTreeGridProbeFilter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E765 RID: 59237 RVA: 0x001424D0 File Offset: 0x001406D0
		public new vtkPHyperTreeGridProbeFilter NewInstance()
		{
			vtkPHyperTreeGridProbeFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPHyperTreeGridProbeFilter.vtkPHyperTreeGridProbeFilter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPHyperTreeGridProbeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E766 RID: 59238
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPHyperTreeGridProbeFilter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E767 RID: 59239 RVA: 0x0014252C File Offset: 0x0014072C
		public new static vtkPHyperTreeGridProbeFilter SafeDownCast(vtkObjectBase o)
		{
			vtkPHyperTreeGridProbeFilter vtkPHyperTreeGridProbeFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPHyperTreeGridProbeFilter.vtkPHyperTreeGridProbeFilter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPHyperTreeGridProbeFilter = (vtkPHyperTreeGridProbeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPHyperTreeGridProbeFilter.Register(null);
				}
			}
			return vtkPHyperTreeGridProbeFilter;
		}

		// Token: 0x0600E768 RID: 59240
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPHyperTreeGridProbeFilter_SetController_09(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set and get the controller.
		/// </summary>
		// Token: 0x0600E769 RID: 59241 RVA: 0x001425AC File Offset: 0x001407AC
		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkPHyperTreeGridProbeFilter.vtkPHyperTreeGridProbeFilter_SetController_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010F5 RID: 4341
		public new const string MRFullTypeName = "Kitware.VTK.vtkPHyperTreeGridProbeFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010F6 RID: 4342
		public new static readonly string MRClassNameKey = "class vtkPHyperTreeGridProbeFilter";
	}
}
