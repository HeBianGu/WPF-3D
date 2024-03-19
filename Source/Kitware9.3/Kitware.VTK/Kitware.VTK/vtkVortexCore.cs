using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVortexCore
	/// </summary>
	/// <remarks>
	///    Compute vortex core lines using the parallel vectors method
	///
	/// vtkVortexCore computes vortex core lines using the parallel vectors method,
	/// as described in
	///
	/// Roth, Martin and Ronald Peikert. “A higher-order method for finding vortex
	/// core lines.” Proceedings Visualization '98 (Cat. No.98CB36276) (1998):
	/// 143-150.
	///
	/// By default, the "Higher-Order" approach of computing the parallel vector
	/// lines between the flow field's velocity and jerk is disabled in favor of
	/// computing the parallel vector lines between the velocity and acceleration,
	/// as suggested in
	///
	/// Haimes, Robert and David N. Kenwright. “On the velocity gradient tensor and
	/// fluid feature extraction.” (1999).
	///
	/// To further discriminate against spurious vortex cores, at each potential point
	/// value the Q-criterion, delta-criterion, and lambda_2-criterion are checked as
	/// defined in
	///
	/// Haller, G. (2005). An objective definition of a vortex. Journal of Fluid
	/// Mechanics, 525, 1-26.
	///
	/// Additionally, the lambda_ci criterion is computed as defined in
	///
	/// Chakraborty, P., Balachandar, S., &amp; Adran, R. (2005). On the relationships
	/// between local vortex identification schemes. Journal of Fluid Mechanics, 535,
	/// 189-214.
	///
	/// The Q-criterion and delta-criterion are used to prefilter cells
	/// prior to the execution of the parallel lines algorithm, and all criteria
	/// values are stored as point values on the output polylines.
	///
	/// The FasterApproximation option uses a faster approximate gradient calculation
	/// to accelerate the vortex core calculation.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkParallelVectors
	/// </seealso>
	// Token: 0x020004CA RID: 1226
	public class vtkVortexCore : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600DFBD RID: 57277 RVA: 0x0013652D File Offset: 0x0013472D
		static vtkVortexCore()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVortexCore.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVortexCore"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600DFBE RID: 57278 RVA: 0x00136555 File Offset: 0x00134755
		public vtkVortexCore(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600DFBF RID: 57279
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVortexCore_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DFC0 RID: 57280 RVA: 0x00136564 File Offset: 0x00134764
		public new static vtkVortexCore New()
		{
			vtkVortexCore result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVortexCore.vtkVortexCore_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVortexCore)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DFC1 RID: 57281 RVA: 0x001365B8 File Offset: 0x001347B8
		public vtkVortexCore() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVortexCore.vtkVortexCore_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600DFC2 RID: 57282 RVA: 0x001365FC File Offset: 0x001347FC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600DFC3 RID: 57283
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVortexCore_FasterApproximationOff_01(HandleRef pThis);

		/// <summary>
		/// When this flag is on, the gradient filter will provide a less accurate (but close)
		/// algorithm that performs fewer derivative calculations (and is therefore faster).
		/// The default is off.
		/// </summary>
		// Token: 0x0600DFC4 RID: 57284 RVA: 0x00136607 File Offset: 0x00134807
		public virtual void FasterApproximationOff()
		{
			vtkVortexCore.vtkVortexCore_FasterApproximationOff_01(base.GetCppThis());
		}

		// Token: 0x0600DFC5 RID: 57285
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVortexCore_FasterApproximationOn_02(HandleRef pThis);

		/// <summary>
		/// When this flag is on, the gradient filter will provide a less accurate (but close)
		/// algorithm that performs fewer derivative calculations (and is therefore faster).
		/// The default is off.
		/// </summary>
		// Token: 0x0600DFC6 RID: 57286 RVA: 0x00136616 File Offset: 0x00134816
		public virtual void FasterApproximationOn()
		{
			vtkVortexCore.vtkVortexCore_FasterApproximationOn_02(base.GetCppThis());
		}

		// Token: 0x0600DFC7 RID: 57287
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVortexCore_GetFasterApproximation_03(HandleRef pThis);

		/// <summary>
		/// When this flag is on, the gradient filter will provide a less accurate (but close)
		/// algorithm that performs fewer derivative calculations (and is therefore faster).
		/// The default is off.
		/// </summary>
		// Token: 0x0600DFC8 RID: 57288 RVA: 0x00136628 File Offset: 0x00134828
		public virtual bool GetFasterApproximation()
		{
			return vtkVortexCore.vtkVortexCore_GetFasterApproximation_03(base.GetCppThis()) != 0;
		}

		// Token: 0x0600DFC9 RID: 57289
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVortexCore_GetHigherOrderMethod_04(HandleRef pThis);

		/// <summary>
		/// When this flag is on, the flow field's jerk is used instead of acceleration as the
		/// second vector field during the parallel vector operation. The default is off.
		/// </summary>
		// Token: 0x0600DFCA RID: 57290 RVA: 0x00136650 File Offset: 0x00134850
		public virtual int GetHigherOrderMethod()
		{
			return vtkVortexCore.vtkVortexCore_GetHigherOrderMethod_04(base.GetCppThis());
		}

		// Token: 0x0600DFCB RID: 57291
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVortexCore_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DFCC RID: 57292 RVA: 0x00136670 File Offset: 0x00134870
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVortexCore.vtkVortexCore_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0600DFCD RID: 57293
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVortexCore_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DFCE RID: 57294 RVA: 0x00136690 File Offset: 0x00134890
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVortexCore.vtkVortexCore_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0600DFCF RID: 57295
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVortexCore_HigherOrderMethodOff_07(HandleRef pThis);

		/// <summary>
		/// When this flag is on, the flow field's jerk is used instead of acceleration as the
		/// second vector field during the parallel vector operation. The default is off.
		/// </summary>
		// Token: 0x0600DFD0 RID: 57296 RVA: 0x001366AA File Offset: 0x001348AA
		public virtual void HigherOrderMethodOff()
		{
			vtkVortexCore.vtkVortexCore_HigherOrderMethodOff_07(base.GetCppThis());
		}

		// Token: 0x0600DFD1 RID: 57297
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVortexCore_HigherOrderMethodOn_08(HandleRef pThis);

		/// <summary>
		/// When this flag is on, the flow field's jerk is used instead of acceleration as the
		/// second vector field during the parallel vector operation. The default is off.
		/// </summary>
		// Token: 0x0600DFD2 RID: 57298 RVA: 0x001366B9 File Offset: 0x001348B9
		public virtual void HigherOrderMethodOn()
		{
			vtkVortexCore.vtkVortexCore_HigherOrderMethodOn_08(base.GetCppThis());
		}

		// Token: 0x0600DFD3 RID: 57299
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVortexCore_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DFD4 RID: 57300 RVA: 0x001366C8 File Offset: 0x001348C8
		public override int IsA(string type)
		{
			return vtkVortexCore.vtkVortexCore_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0600DFD5 RID: 57301
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVortexCore_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DFD6 RID: 57302 RVA: 0x001366E8 File Offset: 0x001348E8
		public new static int IsTypeOf(string type)
		{
			return vtkVortexCore.vtkVortexCore_IsTypeOf_10(type);
		}

		// Token: 0x0600DFD7 RID: 57303
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVortexCore_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DFD8 RID: 57304 RVA: 0x00136704 File Offset: 0x00134904
		public new vtkVortexCore NewInstance()
		{
			vtkVortexCore result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVortexCore.vtkVortexCore_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVortexCore)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600DFD9 RID: 57305
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVortexCore_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DFDA RID: 57306 RVA: 0x00136760 File Offset: 0x00134960
		public new static vtkVortexCore SafeDownCast(vtkObjectBase o)
		{
			vtkVortexCore vtkVortexCore = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVortexCore.vtkVortexCore_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVortexCore = (vtkVortexCore)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVortexCore.Register(null);
				}
			}
			return vtkVortexCore;
		}

		// Token: 0x0600DFDB RID: 57307
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVortexCore_SetFasterApproximation_14(HandleRef pThis, byte _arg);

		/// <summary>
		/// When this flag is on, the gradient filter will provide a less accurate (but close)
		/// algorithm that performs fewer derivative calculations (and is therefore faster).
		/// The default is off.
		/// </summary>
		// Token: 0x0600DFDC RID: 57308 RVA: 0x001367DF File Offset: 0x001349DF
		public virtual void SetFasterApproximation(bool _arg)
		{
			vtkVortexCore.vtkVortexCore_SetFasterApproximation_14(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600DFDD RID: 57309
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVortexCore_SetHigherOrderMethod_15(HandleRef pThis, int _arg);

		/// <summary>
		/// When this flag is on, the flow field's jerk is used instead of acceleration as the
		/// second vector field during the parallel vector operation. The default is off.
		/// </summary>
		// Token: 0x0600DFDE RID: 57310 RVA: 0x001367F7 File Offset: 0x001349F7
		public virtual void SetHigherOrderMethod(int _arg)
		{
			vtkVortexCore.vtkVortexCore_SetHigherOrderMethod_15(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400106F RID: 4207
		public new const string MRFullTypeName = "Kitware.VTK.vtkVortexCore";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001070 RID: 4208
		public new static readonly string MRClassNameKey = "class vtkVortexCore";
	}
}
