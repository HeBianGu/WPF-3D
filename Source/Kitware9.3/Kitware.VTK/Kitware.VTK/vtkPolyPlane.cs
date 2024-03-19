﻿using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolyPlane
	/// </summary>
	/// <remarks>
	///    Implicit function that is generated by extrusion of a polyline along the Z axis
	///
	/// vtkPolyPlane is, as the name suggests, an extrusion of a vtkPolyLine.
	/// The extrusion direction is assumed to be the Z vector. It can be used in
	/// combination with a vtkCutter to cut a dataset with a polyplane.
	/// vtkPolyPlane is a concrete implementation of the abstract class
	/// vtkImplicitFunction.
	///
	/// @todo
	/// Generalize to extrusions along arbitrary directions.
	/// </remarks>
	// Token: 0x02000AA3 RID: 2723
	public class vtkPolyPlane : vtkImplicitFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C97F RID: 117119 RVA: 0x00282D01 File Offset: 0x00280F01
		static vtkPolyPlane()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyPlane.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyPlane"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C980 RID: 117120 RVA: 0x00282D29 File Offset: 0x00280F29
		public vtkPolyPlane(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C981 RID: 117121
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyPlane_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct plane passing through origin and normal to z-axis.
		/// </summary>
		// Token: 0x0601C982 RID: 117122 RVA: 0x00282D38 File Offset: 0x00280F38
		public new static vtkPolyPlane New()
		{
			vtkPolyPlane result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyPlane.vtkPolyPlane_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyPlane)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct plane passing through origin and normal to z-axis.
		/// </summary>
		// Token: 0x0601C983 RID: 117123 RVA: 0x00282D8C File Offset: 0x00280F8C
		public vtkPolyPlane() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPolyPlane.vtkPolyPlane_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C984 RID: 117124 RVA: 0x00282DD0 File Offset: 0x00280FD0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C985 RID: 117125
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolyPlane_EvaluateFunction_01(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Evaluate plane equation for point x[3].
		/// </summary>
		// Token: 0x0601C986 RID: 117126 RVA: 0x00282DDC File Offset: 0x00280FDC
		public override double EvaluateFunction(IntPtr x)
		{
			return vtkPolyPlane.vtkPolyPlane_EvaluateFunction_01(base.GetCppThis(), x);
		}

		// Token: 0x0601C987 RID: 117127
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyPlane_EvaluateGradient_02(HandleRef pThis, IntPtr x, IntPtr g);

		/// <summary>
		/// Evaluate function gradient at point x[3].
		/// </summary>
		// Token: 0x0601C988 RID: 117128 RVA: 0x00282DFC File Offset: 0x00280FFC
		public override void EvaluateGradient(IntPtr x, IntPtr g)
		{
			vtkPolyPlane.vtkPolyPlane_EvaluateGradient_02(base.GetCppThis(), x, g);
		}

		// Token: 0x0601C989 RID: 117129
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkPolyPlane_GetMTime_03(HandleRef pThis);

		/// <summary>
		/// Override GetMTime to include the polyline
		/// </summary>
		// Token: 0x0601C98A RID: 117130 RVA: 0x00282E10 File Offset: 0x00281010
		public override ulong GetMTime()
		{
			return vtkPolyPlane.vtkPolyPlane_GetMTime_03(base.GetCppThis());
		}

		// Token: 0x0601C98B RID: 117131
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyPlane_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct plane passing through origin and normal to z-axis.
		/// </summary>
		// Token: 0x0601C98C RID: 117132 RVA: 0x00282E30 File Offset: 0x00281030
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPolyPlane.vtkPolyPlane_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601C98D RID: 117133
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyPlane_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct plane passing through origin and normal to z-axis.
		/// </summary>
		// Token: 0x0601C98E RID: 117134 RVA: 0x00282E50 File Offset: 0x00281050
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPolyPlane.vtkPolyPlane_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601C98F RID: 117135
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyPlane_GetPolyLine_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get point through which plane passes. Plane is defined by point
		/// and normal.
		/// </summary>
		// Token: 0x0601C990 RID: 117136 RVA: 0x00282E6C File Offset: 0x0028106C
		public virtual vtkPolyLine GetPolyLine()
		{
			vtkPolyLine vtkPolyLine = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyPlane.vtkPolyPlane_GetPolyLine_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyLine = (vtkPolyLine)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyLine.Register(null);
				}
			}
			return vtkPolyLine;
		}

		// Token: 0x0601C991 RID: 117137
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyPlane_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct plane passing through origin and normal to z-axis.
		/// </summary>
		// Token: 0x0601C992 RID: 117138 RVA: 0x00282EDC File Offset: 0x002810DC
		public override int IsA(string type)
		{
			return vtkPolyPlane.vtkPolyPlane_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601C993 RID: 117139
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyPlane_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct plane passing through origin and normal to z-axis.
		/// </summary>
		// Token: 0x0601C994 RID: 117140 RVA: 0x00282EFC File Offset: 0x002810FC
		public new static int IsTypeOf(string type)
		{
			return vtkPolyPlane.vtkPolyPlane_IsTypeOf_08(type);
		}

		// Token: 0x0601C995 RID: 117141
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyPlane_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct plane passing through origin and normal to z-axis.
		/// </summary>
		// Token: 0x0601C996 RID: 117142 RVA: 0x00282F18 File Offset: 0x00281118
		public new vtkPolyPlane NewInstance()
		{
			vtkPolyPlane result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyPlane.vtkPolyPlane_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyPlane)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C997 RID: 117143
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyPlane_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct plane passing through origin and normal to z-axis.
		/// </summary>
		// Token: 0x0601C998 RID: 117144 RVA: 0x00282F74 File Offset: 0x00281174
		public new static vtkPolyPlane SafeDownCast(vtkObjectBase o)
		{
			vtkPolyPlane vtkPolyPlane = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyPlane.vtkPolyPlane_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyPlane = (vtkPolyPlane)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyPlane.Register(null);
				}
			}
			return vtkPolyPlane;
		}

		// Token: 0x0601C999 RID: 117145
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyPlane_SetPolyLine_12(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/get point through which plane passes. Plane is defined by point
		/// and normal.
		/// </summary>
		// Token: 0x0601C99A RID: 117146 RVA: 0x00282FF4 File Offset: 0x002811F4
		public virtual void SetPolyLine(vtkPolyLine arg0)
		{
			vtkPolyPlane.vtkPolyPlane_SetPolyLine_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E4D RID: 7757
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyPlane";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E4E RID: 7758
		public new static readonly string MRClassNameKey = "class vtkPolyPlane";
	}
}
