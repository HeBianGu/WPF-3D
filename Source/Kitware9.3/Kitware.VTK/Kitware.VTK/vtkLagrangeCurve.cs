using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000A77 RID: 2679
	public class vtkLagrangeCurve : vtkHigherOrderCurve
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C148 RID: 115016 RVA: 0x00275B33 File Offset: 0x00273D33
		static vtkLagrangeCurve()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLagrangeCurve.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLagrangeCurve"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C149 RID: 115017 RVA: 0x00275B5B File Offset: 0x00273D5B
		public vtkLagrangeCurve(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C14A RID: 115018
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeCurve_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601C14B RID: 115019 RVA: 0x00275B6C File Offset: 0x00273D6C
		public new static vtkLagrangeCurve New()
		{
			vtkLagrangeCurve result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeCurve.vtkLagrangeCurve_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLagrangeCurve)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C14C RID: 115020 RVA: 0x00275BC0 File Offset: 0x00273DC0
		public vtkLagrangeCurve() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLagrangeCurve.vtkLagrangeCurve_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C14D RID: 115021 RVA: 0x00275C04 File Offset: 0x00273E04
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C14E RID: 115022
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangeCurve_GetCellType_01(HandleRef pThis);

		// Token: 0x0601C14F RID: 115023 RVA: 0x00275C10 File Offset: 0x00273E10
		public override int GetCellType()
		{
			return vtkLagrangeCurve.vtkLagrangeCurve_GetCellType_01(base.GetCppThis());
		}

		// Token: 0x0601C150 RID: 115024
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLagrangeCurve_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601C151 RID: 115025 RVA: 0x00275C30 File Offset: 0x00273E30
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLagrangeCurve.vtkLagrangeCurve_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601C152 RID: 115026
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLagrangeCurve_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601C153 RID: 115027 RVA: 0x00275C50 File Offset: 0x00273E50
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLagrangeCurve.vtkLagrangeCurve_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601C154 RID: 115028
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangeCurve_InterpolateDerivs_04(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		// Token: 0x0601C155 RID: 115029 RVA: 0x00275C6A File Offset: 0x00273E6A
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkLagrangeCurve.vtkLagrangeCurve_InterpolateDerivs_04(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601C156 RID: 115030
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangeCurve_InterpolateFunctions_05(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		// Token: 0x0601C157 RID: 115031 RVA: 0x00275C7B File Offset: 0x00273E7B
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkLagrangeCurve.vtkLagrangeCurve_InterpolateFunctions_05(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601C158 RID: 115032
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangeCurve_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601C159 RID: 115033 RVA: 0x00275C8C File Offset: 0x00273E8C
		public override int IsA(string type)
		{
			return vtkLagrangeCurve.vtkLagrangeCurve_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601C15A RID: 115034
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangeCurve_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601C15B RID: 115035 RVA: 0x00275CAC File Offset: 0x00273EAC
		public new static int IsTypeOf(string type)
		{
			return vtkLagrangeCurve.vtkLagrangeCurve_IsTypeOf_07(type);
		}

		// Token: 0x0601C15C RID: 115036
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeCurve_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601C15D RID: 115037 RVA: 0x00275CC8 File Offset: 0x00273EC8
		public new vtkLagrangeCurve NewInstance()
		{
			vtkLagrangeCurve result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeCurve.vtkLagrangeCurve_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLagrangeCurve)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C15E RID: 115038
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeCurve_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601C15F RID: 115039 RVA: 0x00275D24 File Offset: 0x00273F24
		public new static vtkLagrangeCurve SafeDownCast(vtkObjectBase o)
		{
			vtkLagrangeCurve vtkLagrangeCurve = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeCurve.vtkLagrangeCurve_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLagrangeCurve = (vtkLagrangeCurve)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLagrangeCurve.Register(null);
				}
			}
			return vtkLagrangeCurve;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DE5 RID: 7653
		public new const string MRFullTypeName = "Kitware.VTK.vtkLagrangeCurve";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DE6 RID: 7654
		public new static readonly string MRClassNameKey = "class vtkLagrangeCurve";
	}
}
