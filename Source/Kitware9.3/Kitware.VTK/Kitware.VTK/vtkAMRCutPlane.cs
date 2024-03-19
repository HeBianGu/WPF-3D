using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAMRCutPlane
	///
	///
	///  A concrete instance of vtkMultiBlockDataSet that provides functionality for
	/// cutting an AMR dataset (an instance of vtkOverlappingAMR) with user supplied
	/// implicit plane function defined by a normal and center.
	/// </summary>
	// Token: 0x020004E8 RID: 1256
	public class vtkAMRCutPlane : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E2F7 RID: 58103 RVA: 0x0013C0B7 File Offset: 0x0013A2B7
		static vtkAMRCutPlane()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAMRCutPlane.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAMRCutPlane"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E2F8 RID: 58104 RVA: 0x0013C0DF File Offset: 0x0013A2DF
		public vtkAMRCutPlane(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E2F9 RID: 58105
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRCutPlane_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E2FA RID: 58106 RVA: 0x0013C0F0 File Offset: 0x0013A2F0
		public new static vtkAMRCutPlane New()
		{
			vtkAMRCutPlane result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRCutPlane.vtkAMRCutPlane_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAMRCutPlane)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E2FB RID: 58107 RVA: 0x0013C144 File Offset: 0x0013A344
		public vtkAMRCutPlane() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAMRCutPlane.vtkAMRCutPlane_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E2FC RID: 58108 RVA: 0x0013C188 File Offset: 0x0013A388
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E2FD RID: 58109
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRCutPlane_FillInputPortInformation_01(HandleRef pThis, int port, HandleRef info);

		/// <summary>
		/// Set/Get a multiprocess controller for parallel processing.
		/// By default this parameter is set to nullptr by the constructor.
		/// </summary>
		// Token: 0x0600E2FE RID: 58110 RVA: 0x0013C194 File Offset: 0x0013A394
		public virtual int FillInputPortInformation(int port, vtkInformation info)
		{
			return vtkAMRCutPlane.vtkAMRCutPlane_FillInputPortInformation_01(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0600E2FF RID: 58111
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRCutPlane_FillOutputPortInformation_02(HandleRef pThis, int port, HandleRef info);

		/// <summary>
		/// Set/Get a multiprocess controller for parallel processing.
		/// By default this parameter is set to nullptr by the constructor.
		/// </summary>
		// Token: 0x0600E300 RID: 58112 RVA: 0x0013C1CC File Offset: 0x0013A3CC
		public virtual int FillOutputPortInformation(int port, vtkInformation info)
		{
			return vtkAMRCutPlane.vtkAMRCutPlane_FillOutputPortInformation_02(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0600E301 RID: 58113
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRCutPlane_GetController_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get a multiprocess controller for parallel processing.
		/// By default this parameter is set to nullptr by the constructor.
		/// </summary>
		// Token: 0x0600E302 RID: 58114 RVA: 0x0013C204 File Offset: 0x0013A404
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRCutPlane.vtkAMRCutPlane_GetController_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600E303 RID: 58115
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRCutPlane_GetLevelOfResolution_04(HandleRef pThis);

		/// <summary>
		/// Sets the level of resolution
		/// </summary>
		// Token: 0x0600E304 RID: 58116 RVA: 0x0013C274 File Offset: 0x0013A474
		public virtual int GetLevelOfResolution()
		{
			return vtkAMRCutPlane.vtkAMRCutPlane_GetLevelOfResolution_04(base.GetCppThis());
		}

		// Token: 0x0600E305 RID: 58117
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAMRCutPlane_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E306 RID: 58118 RVA: 0x0013C294 File Offset: 0x0013A494
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAMRCutPlane.vtkAMRCutPlane_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0600E307 RID: 58119
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAMRCutPlane_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E308 RID: 58120 RVA: 0x0013C2B4 File Offset: 0x0013A4B4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAMRCutPlane.vtkAMRCutPlane_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0600E309 RID: 58121
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAMRCutPlane_GetUseNativeCutter_07(HandleRef pThis);

		/// <summary>
		/// Sets if plane cutter is used instead of the specialized AMR cutter.
		///
		/// Default is true.
		/// </summary>
		// Token: 0x0600E30A RID: 58122 RVA: 0x0013C2D0 File Offset: 0x0013A4D0
		public virtual bool GetUseNativeCutter()
		{
			return vtkAMRCutPlane.vtkAMRCutPlane_GetUseNativeCutter_07(base.GetCppThis()) != 0;
		}

		// Token: 0x0600E30B RID: 58123
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRCutPlane_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E30C RID: 58124 RVA: 0x0013C2F8 File Offset: 0x0013A4F8
		public override int IsA(string type)
		{
			return vtkAMRCutPlane.vtkAMRCutPlane_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0600E30D RID: 58125
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRCutPlane_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E30E RID: 58126 RVA: 0x0013C318 File Offset: 0x0013A518
		public new static int IsTypeOf(string type)
		{
			return vtkAMRCutPlane.vtkAMRCutPlane_IsTypeOf_09(type);
		}

		// Token: 0x0600E30F RID: 58127
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRCutPlane_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E310 RID: 58128 RVA: 0x0013C334 File Offset: 0x0013A534
		public new vtkAMRCutPlane NewInstance()
		{
			vtkAMRCutPlane result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRCutPlane.vtkAMRCutPlane_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAMRCutPlane)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E311 RID: 58129
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRCutPlane_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E312 RID: 58130 RVA: 0x0013C390 File Offset: 0x0013A590
		public new static vtkAMRCutPlane SafeDownCast(vtkObjectBase o)
		{
			vtkAMRCutPlane vtkAMRCutPlane = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRCutPlane.vtkAMRCutPlane_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAMRCutPlane = (vtkAMRCutPlane)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAMRCutPlane.Register(null);
				}
			}
			return vtkAMRCutPlane;
		}

		// Token: 0x0600E313 RID: 58131
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRCutPlane_SetCenter_13(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Sets the center
		/// </summary>
		// Token: 0x0600E314 RID: 58132 RVA: 0x0013C40F File Offset: 0x0013A60F
		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkAMRCutPlane.vtkAMRCutPlane_SetCenter_13(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600E315 RID: 58133
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRCutPlane_SetCenter_14(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Sets the center
		/// </summary>
		// Token: 0x0600E316 RID: 58134 RVA: 0x0013C421 File Offset: 0x0013A621
		public virtual void SetCenter(IntPtr _arg)
		{
			vtkAMRCutPlane.vtkAMRCutPlane_SetCenter_14(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E317 RID: 58135
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRCutPlane_SetController_15(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get a multiprocess controller for parallel processing.
		/// By default this parameter is set to nullptr by the constructor.
		/// </summary>
		// Token: 0x0600E318 RID: 58136 RVA: 0x0013C434 File Offset: 0x0013A634
		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkAMRCutPlane.vtkAMRCutPlane_SetController_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600E319 RID: 58137
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRCutPlane_SetInitialRequest_16(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set if it's the initial request.
		/// </summary>
		// Token: 0x0600E31A RID: 58138 RVA: 0x0013C463 File Offset: 0x0013A663
		public virtual void SetInitialRequest(bool _arg)
		{
			vtkAMRCutPlane.vtkAMRCutPlane_SetInitialRequest_16(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600E31B RID: 58139
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRCutPlane_SetLevelOfResolution_17(HandleRef pThis, int _arg);

		/// <summary>
		/// Sets the level of resolution
		/// </summary>
		// Token: 0x0600E31C RID: 58140 RVA: 0x0013C47B File Offset: 0x0013A67B
		public virtual void SetLevelOfResolution(int _arg)
		{
			vtkAMRCutPlane.vtkAMRCutPlane_SetLevelOfResolution_17(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E31D RID: 58141
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRCutPlane_SetNormal_18(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Sets the normal
		/// </summary>
		// Token: 0x0600E31E RID: 58142 RVA: 0x0013C48B File Offset: 0x0013A68B
		public virtual void SetNormal(double _arg1, double _arg2, double _arg3)
		{
			vtkAMRCutPlane.vtkAMRCutPlane_SetNormal_18(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600E31F RID: 58143
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRCutPlane_SetNormal_19(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Sets the normal
		/// </summary>
		// Token: 0x0600E320 RID: 58144 RVA: 0x0013C49D File Offset: 0x0013A69D
		public virtual void SetNormal(IntPtr _arg)
		{
			vtkAMRCutPlane.vtkAMRCutPlane_SetNormal_19(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E321 RID: 58145
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRCutPlane_SetUseNativeCutter_20(HandleRef pThis, byte _arg);

		/// <summary>
		/// Sets if plane cutter is used instead of the specialized AMR cutter.
		///
		/// Default is true.
		/// </summary>
		// Token: 0x0600E322 RID: 58146 RVA: 0x0013C4AD File Offset: 0x0013A6AD
		public virtual void SetUseNativeCutter(bool _arg)
		{
			vtkAMRCutPlane.vtkAMRCutPlane_SetUseNativeCutter_20(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600E323 RID: 58147
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRCutPlane_UseNativeCutterOff_21(HandleRef pThis);

		/// <summary>
		/// Sets if plane cutter is used instead of the specialized AMR cutter.
		///
		/// Default is true.
		/// </summary>
		// Token: 0x0600E324 RID: 58148 RVA: 0x0013C4C5 File Offset: 0x0013A6C5
		public virtual void UseNativeCutterOff()
		{
			vtkAMRCutPlane.vtkAMRCutPlane_UseNativeCutterOff_21(base.GetCppThis());
		}

		// Token: 0x0600E325 RID: 58149
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRCutPlane_UseNativeCutterOn_22(HandleRef pThis);

		/// <summary>
		/// Sets if plane cutter is used instead of the specialized AMR cutter.
		///
		/// Default is true.
		/// </summary>
		// Token: 0x0600E326 RID: 58150 RVA: 0x0013C4D4 File Offset: 0x0013A6D4
		public virtual void UseNativeCutterOn()
		{
			vtkAMRCutPlane.vtkAMRCutPlane_UseNativeCutterOn_22(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010B3 RID: 4275
		public new const string MRFullTypeName = "Kitware.VTK.vtkAMRCutPlane";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010B4 RID: 4276
		public new static readonly string MRClassNameKey = "class vtkAMRCutPlane";
	}
}
