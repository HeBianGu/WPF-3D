using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLagrangianMatidaIntegrationModel
	/// vtkLagrangianBasicIntegrationModel implementation
	///
	///
	/// vtkLagrangianBasicIntegrationModel implementation using
	/// article :
	/// "Matida, E. A., et al. "Improved numerical simulation of aerosol deposition in
	/// an idealized mouth-throat." Journal of Aerosol Science 35.1 (2004): 1-19."
	/// Input Array to process are expected as follow :
	/// Index 1 is the "FlowVelocity" from flow input in the tracker
	/// Index 2 is the "FlowDensity" from flow input in the tracker
	/// Index 3 is the "FlowDynamicViscosity" from flow input in the tracker
	/// Index 4 is the "ParticleDiameter" from seed (source) input in the tracker
	/// Index 5 is the "ParticleDensity" from seed (source) input in the tracker
	///
	/// </summary>
	/// <seealso>
	///
	/// vtkLagrangianParticleTracker vtkLagrangianParticle
	/// vtkLagrangianBasicIntegrationModel
	/// </seealso>
	// Token: 0x020004B1 RID: 1201
	public class vtkLagrangianMatidaIntegrationModel : vtkLagrangianBasicIntegrationModel
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600DC95 RID: 56469 RVA: 0x001321D1 File Offset: 0x001303D1
		static vtkLagrangianMatidaIntegrationModel()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLagrangianMatidaIntegrationModel.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLagrangianMatidaIntegrationModel"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600DC96 RID: 56470 RVA: 0x001321F9 File Offset: 0x001303F9
		public vtkLagrangianMatidaIntegrationModel(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600DC97 RID: 56471
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangianMatidaIntegrationModel_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DC98 RID: 56472 RVA: 0x00132208 File Offset: 0x00130408
		public new static vtkLagrangianMatidaIntegrationModel New()
		{
			vtkLagrangianMatidaIntegrationModel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangianMatidaIntegrationModel.vtkLagrangianMatidaIntegrationModel_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLagrangianMatidaIntegrationModel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DC99 RID: 56473 RVA: 0x0013225C File Offset: 0x0013045C
		public vtkLagrangianMatidaIntegrationModel() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLagrangianMatidaIntegrationModel.vtkLagrangianMatidaIntegrationModel_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600DC9A RID: 56474 RVA: 0x001322A0 File Offset: 0x001304A0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600DC9B RID: 56475
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangianMatidaIntegrationModel_GetGravity_01(HandleRef pThis);

		/// <summary>
		/// Specify the acceleration of gravity.
		/// Default value is (0, 0, -9.8)
		/// </summary>
		// Token: 0x0600DC9C RID: 56476 RVA: 0x001322AC File Offset: 0x001304AC
		public virtual double[] GetGravity()
		{
			IntPtr intPtr = vtkLagrangianMatidaIntegrationModel.vtkLagrangianMatidaIntegrationModel_GetGravity_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600DC9D RID: 56477
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianMatidaIntegrationModel_GetGravity_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Specify the acceleration of gravity.
		/// Default value is (0, 0, -9.8)
		/// </summary>
		// Token: 0x0600DC9E RID: 56478 RVA: 0x001322F4 File Offset: 0x001304F4
		public virtual void GetGravity(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkLagrangianMatidaIntegrationModel.vtkLagrangianMatidaIntegrationModel_GetGravity_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600DC9F RID: 56479
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianMatidaIntegrationModel_GetGravity_03(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the acceleration of gravity.
		/// Default value is (0, 0, -9.8)
		/// </summary>
		// Token: 0x0600DCA0 RID: 56480 RVA: 0x00132306 File Offset: 0x00130506
		public virtual void GetGravity(IntPtr _arg)
		{
			vtkLagrangianMatidaIntegrationModel.vtkLagrangianMatidaIntegrationModel_GetGravity_03(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DCA1 RID: 56481
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLagrangianMatidaIntegrationModel_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DCA2 RID: 56482 RVA: 0x00132318 File Offset: 0x00130518
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLagrangianMatidaIntegrationModel.vtkLagrangianMatidaIntegrationModel_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600DCA3 RID: 56483
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLagrangianMatidaIntegrationModel_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DCA4 RID: 56484 RVA: 0x00132338 File Offset: 0x00130538
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLagrangianMatidaIntegrationModel.vtkLagrangianMatidaIntegrationModel_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600DCA5 RID: 56485
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangianMatidaIntegrationModel_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DCA6 RID: 56486 RVA: 0x00132354 File Offset: 0x00130554
		public override int IsA(string type)
		{
			return vtkLagrangianMatidaIntegrationModel.vtkLagrangianMatidaIntegrationModel_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0600DCA7 RID: 56487
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangianMatidaIntegrationModel_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DCA8 RID: 56488 RVA: 0x00132374 File Offset: 0x00130574
		public new static int IsTypeOf(string type)
		{
			return vtkLagrangianMatidaIntegrationModel.vtkLagrangianMatidaIntegrationModel_IsTypeOf_07(type);
		}

		// Token: 0x0600DCA9 RID: 56489
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangianMatidaIntegrationModel_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DCAA RID: 56490 RVA: 0x00132390 File Offset: 0x00130590
		public new vtkLagrangianMatidaIntegrationModel NewInstance()
		{
			vtkLagrangianMatidaIntegrationModel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangianMatidaIntegrationModel.vtkLagrangianMatidaIntegrationModel_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLagrangianMatidaIntegrationModel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600DCAB RID: 56491
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangianMatidaIntegrationModel_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DCAC RID: 56492 RVA: 0x001323EC File Offset: 0x001305EC
		public new static vtkLagrangianMatidaIntegrationModel SafeDownCast(vtkObjectBase o)
		{
			vtkLagrangianMatidaIntegrationModel vtkLagrangianMatidaIntegrationModel = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangianMatidaIntegrationModel.vtkLagrangianMatidaIntegrationModel_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLagrangianMatidaIntegrationModel = (vtkLagrangianMatidaIntegrationModel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLagrangianMatidaIntegrationModel.Register(null);
				}
			}
			return vtkLagrangianMatidaIntegrationModel;
		}

		// Token: 0x0600DCAD RID: 56493
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianMatidaIntegrationModel_SetGravity_11(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Specify the acceleration of gravity.
		/// Default value is (0, 0, -9.8)
		/// </summary>
		// Token: 0x0600DCAE RID: 56494 RVA: 0x0013246B File Offset: 0x0013066B
		public virtual void SetGravity(double _arg1, double _arg2, double _arg3)
		{
			vtkLagrangianMatidaIntegrationModel.vtkLagrangianMatidaIntegrationModel_SetGravity_11(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600DCAF RID: 56495
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianMatidaIntegrationModel_SetGravity_12(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the acceleration of gravity.
		/// Default value is (0, 0, -9.8)
		/// </summary>
		// Token: 0x0600DCB0 RID: 56496 RVA: 0x0013247D File Offset: 0x0013067D
		public virtual void SetGravity(IntPtr _arg)
		{
			vtkLagrangianMatidaIntegrationModel.vtkLagrangianMatidaIntegrationModel_SetGravity_12(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400101F RID: 4127
		public new const string MRFullTypeName = "Kitware.VTK.vtkLagrangianMatidaIntegrationModel";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001020 RID: 4128
		public new static readonly string MRClassNameKey = "class vtkLagrangianMatidaIntegrationModel";
	}
}
