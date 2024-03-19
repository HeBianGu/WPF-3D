using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x0200060A RID: 1546
	public class vtkForceTime : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010C6C RID: 68716 RVA: 0x0017671F File Offset: 0x0017491F
		static vtkForceTime()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkForceTime.MRClassNameKey, Type.GetType("Kitware.VTK.vtkForceTime"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010C6D RID: 68717 RVA: 0x00176747 File Offset: 0x00174947
		public vtkForceTime(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010C6E RID: 68718
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkForceTime_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06010C6F RID: 68719 RVA: 0x00176758 File Offset: 0x00174958
		public new static vtkForceTime New()
		{
			vtkForceTime result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkForceTime.vtkForceTime_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkForceTime)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010C70 RID: 68720 RVA: 0x001767AC File Offset: 0x001749AC
		public vtkForceTime() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkForceTime.vtkForceTime_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010C71 RID: 68721 RVA: 0x001767F0 File Offset: 0x001749F0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010C72 RID: 68722
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkForceTime_GetForcedTime_01(HandleRef pThis);

		// Token: 0x06010C73 RID: 68723 RVA: 0x001767FC File Offset: 0x001749FC
		public virtual double GetForcedTime()
		{
			return vtkForceTime.vtkForceTime_GetForcedTime_01(base.GetCppThis());
		}

		// Token: 0x06010C74 RID: 68724
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkForceTime_GetIgnorePipelineTime_02(HandleRef pThis);

		// Token: 0x06010C75 RID: 68725 RVA: 0x0017681C File Offset: 0x00174A1C
		public virtual bool GetIgnorePipelineTime()
		{
			return vtkForceTime.vtkForceTime_GetIgnorePipelineTime_02(base.GetCppThis()) != 0;
		}

		// Token: 0x06010C76 RID: 68726
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkForceTime_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x06010C77 RID: 68727 RVA: 0x00176844 File Offset: 0x00174A44
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkForceTime.vtkForceTime_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06010C78 RID: 68728
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkForceTime_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x06010C79 RID: 68729 RVA: 0x00176864 File Offset: 0x00174A64
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkForceTime.vtkForceTime_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06010C7A RID: 68730
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkForceTime_IgnorePipelineTimeOff_05(HandleRef pThis);

		// Token: 0x06010C7B RID: 68731 RVA: 0x0017687E File Offset: 0x00174A7E
		public virtual void IgnorePipelineTimeOff()
		{
			vtkForceTime.vtkForceTime_IgnorePipelineTimeOff_05(base.GetCppThis());
		}

		// Token: 0x06010C7C RID: 68732
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkForceTime_IgnorePipelineTimeOn_06(HandleRef pThis);

		// Token: 0x06010C7D RID: 68733 RVA: 0x0017688D File Offset: 0x00174A8D
		public virtual void IgnorePipelineTimeOn()
		{
			vtkForceTime.vtkForceTime_IgnorePipelineTimeOn_06(base.GetCppThis());
		}

		// Token: 0x06010C7E RID: 68734
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkForceTime_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x06010C7F RID: 68735 RVA: 0x0017689C File Offset: 0x00174A9C
		public override int IsA(string type)
		{
			return vtkForceTime.vtkForceTime_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06010C80 RID: 68736
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkForceTime_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x06010C81 RID: 68737 RVA: 0x001768BC File Offset: 0x00174ABC
		public new static int IsTypeOf(string type)
		{
			return vtkForceTime.vtkForceTime_IsTypeOf_08(type);
		}

		// Token: 0x06010C82 RID: 68738
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkForceTime_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06010C83 RID: 68739 RVA: 0x001768D8 File Offset: 0x00174AD8
		public new vtkForceTime NewInstance()
		{
			vtkForceTime result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkForceTime.vtkForceTime_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkForceTime)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010C84 RID: 68740
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkForceTime_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06010C85 RID: 68741 RVA: 0x00176934 File Offset: 0x00174B34
		public new static vtkForceTime SafeDownCast(vtkObjectBase o)
		{
			vtkForceTime vtkForceTime = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkForceTime.vtkForceTime_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkForceTime = (vtkForceTime)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkForceTime.Register(null);
				}
			}
			return vtkForceTime;
		}

		// Token: 0x06010C86 RID: 68742
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkForceTime_SetForcedTime_12(HandleRef pThis, double _arg);

		// Token: 0x06010C87 RID: 68743 RVA: 0x001769B3 File Offset: 0x00174BB3
		public virtual void SetForcedTime(double _arg)
		{
			vtkForceTime.vtkForceTime_SetForcedTime_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06010C88 RID: 68744
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkForceTime_SetIgnorePipelineTime_13(HandleRef pThis, byte _arg);

		// Token: 0x06010C89 RID: 68745 RVA: 0x001769C3 File Offset: 0x00174BC3
		public virtual void SetIgnorePipelineTime(bool _arg)
		{
			vtkForceTime.vtkForceTime_SetIgnorePipelineTime_13(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400136E RID: 4974
		public new const string MRFullTypeName = "Kitware.VTK.vtkForceTime";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400136F RID: 4975
		public new static readonly string MRClassNameKey = "class vtkForceTime";
	}
}
