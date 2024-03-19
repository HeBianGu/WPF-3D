using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000A00 RID: 2560
	public class vtkBezierCurve : vtkHigherOrderCurve
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A92D RID: 108845 RVA: 0x0024F1A1 File Offset: 0x0024D3A1
		static vtkBezierCurve()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBezierCurve.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBezierCurve"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A92E RID: 108846 RVA: 0x0024F1C9 File Offset: 0x0024D3C9
		public vtkBezierCurve(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A92F RID: 108847
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierCurve_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601A930 RID: 108848 RVA: 0x0024F1D8 File Offset: 0x0024D3D8
		public new static vtkBezierCurve New()
		{
			vtkBezierCurve result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierCurve.vtkBezierCurve_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBezierCurve)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A931 RID: 108849 RVA: 0x0024F22C File Offset: 0x0024D42C
		public vtkBezierCurve() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBezierCurve.vtkBezierCurve_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A932 RID: 108850 RVA: 0x0024F270 File Offset: 0x0024D470
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A933 RID: 108851
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBezierCurve_GetCellType_01(HandleRef pThis);

		// Token: 0x0601A934 RID: 108852 RVA: 0x0024F27C File Offset: 0x0024D47C
		public override int GetCellType()
		{
			return vtkBezierCurve.vtkBezierCurve_GetCellType_01(base.GetCppThis());
		}

		// Token: 0x0601A935 RID: 108853
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBezierCurve_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601A936 RID: 108854 RVA: 0x0024F29C File Offset: 0x0024D49C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBezierCurve.vtkBezierCurve_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601A937 RID: 108855
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBezierCurve_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601A938 RID: 108856 RVA: 0x0024F2BC File Offset: 0x0024D4BC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBezierCurve.vtkBezierCurve_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601A939 RID: 108857
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierCurve_GetRationalWeights_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601A93A RID: 108858 RVA: 0x0024F2D8 File Offset: 0x0024D4D8
		public vtkDoubleArray GetRationalWeights()
		{
			vtkDoubleArray vtkDoubleArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierCurve.vtkBezierCurve_GetRationalWeights_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDoubleArray = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDoubleArray.Register(null);
				}
			}
			return vtkDoubleArray;
		}

		// Token: 0x0601A93B RID: 108859
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBezierCurve_InterpolateDerivs_05(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		// Token: 0x0601A93C RID: 108860 RVA: 0x0024F347 File Offset: 0x0024D547
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkBezierCurve.vtkBezierCurve_InterpolateDerivs_05(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601A93D RID: 108861
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBezierCurve_InterpolateFunctions_06(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		// Token: 0x0601A93E RID: 108862 RVA: 0x0024F358 File Offset: 0x0024D558
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkBezierCurve.vtkBezierCurve_InterpolateFunctions_06(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601A93F RID: 108863
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBezierCurve_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601A940 RID: 108864 RVA: 0x0024F36C File Offset: 0x0024D56C
		public override int IsA(string type)
		{
			return vtkBezierCurve.vtkBezierCurve_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601A941 RID: 108865
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBezierCurve_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601A942 RID: 108866 RVA: 0x0024F38C File Offset: 0x0024D58C
		public new static int IsTypeOf(string type)
		{
			return vtkBezierCurve.vtkBezierCurve_IsTypeOf_08(type);
		}

		// Token: 0x0601A943 RID: 108867
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierCurve_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601A944 RID: 108868 RVA: 0x0024F3A8 File Offset: 0x0024D5A8
		public new vtkBezierCurve NewInstance()
		{
			vtkBezierCurve result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierCurve.vtkBezierCurve_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBezierCurve)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A945 RID: 108869
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierCurve_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601A946 RID: 108870 RVA: 0x0024F404 File Offset: 0x0024D604
		public new static vtkBezierCurve SafeDownCast(vtkObjectBase o)
		{
			vtkBezierCurve vtkBezierCurve = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierCurve.vtkBezierCurve_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBezierCurve = (vtkBezierCurve)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBezierCurve.Register(null);
				}
			}
			return vtkBezierCurve;
		}

		// Token: 0x0601A947 RID: 108871
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBezierCurve_SetRationalWeightsFromPointData_12(HandleRef pThis, HandleRef point_data, long numPts);

		// Token: 0x0601A948 RID: 108872 RVA: 0x0024F484 File Offset: 0x0024D684
		public void SetRationalWeightsFromPointData(vtkPointData point_data, long numPts)
		{
			vtkBezierCurve.vtkBezierCurve_SetRationalWeightsFromPointData_12(base.GetCppThis(), (point_data == null) ? default(HandleRef) : point_data.GetCppThis(), numPts);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CD8 RID: 7384
		public new const string MRFullTypeName = "Kitware.VTK.vtkBezierCurve";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CD9 RID: 7385
		public new static readonly string MRClassNameKey = "class vtkBezierCurve";
	}
}
