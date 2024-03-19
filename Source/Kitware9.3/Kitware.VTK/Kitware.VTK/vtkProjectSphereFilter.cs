using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkProjectSphereFilter
	/// </summary>
	/// <remarks>
	///    A filter to 'unroll' a sphere.  The
	/// unroll longitude is -180.
	///
	///
	/// </remarks>
	// Token: 0x02000529 RID: 1321
	public class vtkProjectSphereFilter : vtkPointSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600EC3D RID: 60477 RVA: 0x00149657 File Offset: 0x00147857
		static vtkProjectSphereFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProjectSphereFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProjectSphereFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600EC3E RID: 60478 RVA: 0x0014967F File Offset: 0x0014787F
		public vtkProjectSphereFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600EC3F RID: 60479
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProjectSphereFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC40 RID: 60480 RVA: 0x00149690 File Offset: 0x00147890
		public new static vtkProjectSphereFilter New()
		{
			vtkProjectSphereFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProjectSphereFilter.vtkProjectSphereFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProjectSphereFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC41 RID: 60481 RVA: 0x001496E4 File Offset: 0x001478E4
		public vtkProjectSphereFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkProjectSphereFilter.vtkProjectSphereFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600EC42 RID: 60482 RVA: 0x00149728 File Offset: 0x00147928
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600EC43 RID: 60483
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProjectSphereFilter_GetCenter_01(HandleRef pThis);

		/// <summary>
		/// Set the center of the sphere to be split. Default is 0,0,0.
		/// </summary>
		// Token: 0x0600EC44 RID: 60484 RVA: 0x00149734 File Offset: 0x00147934
		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkProjectSphereFilter.vtkProjectSphereFilter_GetCenter_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600EC45 RID: 60485
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectSphereFilter_GetCenter_02(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the center of the sphere to be split. Default is 0,0,0.
		/// </summary>
		// Token: 0x0600EC46 RID: 60486 RVA: 0x0014977C File Offset: 0x0014797C
		public virtual void GetCenter(IntPtr data)
		{
			vtkProjectSphereFilter.vtkProjectSphereFilter_GetCenter_02(base.GetCppThis(), data);
		}

		// Token: 0x0600EC47 RID: 60487
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkProjectSphereFilter_GetKeepPolePoints_03(HandleRef pThis);

		/// <summary>
		/// Specify whether or not to keep the cells using a point at
		/// a pole. The default is false.
		/// </summary>
		// Token: 0x0600EC48 RID: 60488 RVA: 0x0014978C File Offset: 0x0014798C
		public virtual bool GetKeepPolePoints()
		{
			return vtkProjectSphereFilter.vtkProjectSphereFilter_GetKeepPolePoints_03(base.GetCppThis()) != 0;
		}

		// Token: 0x0600EC49 RID: 60489
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProjectSphereFilter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC4A RID: 60490 RVA: 0x001497B4 File Offset: 0x001479B4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkProjectSphereFilter.vtkProjectSphereFilter_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600EC4B RID: 60491
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProjectSphereFilter_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC4C RID: 60492 RVA: 0x001497D4 File Offset: 0x001479D4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkProjectSphereFilter.vtkProjectSphereFilter_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600EC4D RID: 60493
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkProjectSphereFilter_GetTranslateZ_06(HandleRef pThis);

		/// <summary>
		/// Specify whether (true) or not to translate the points in the projected
		/// transformation such that the input point with the smallest
		/// radius is at 0. The default is false.
		/// </summary>
		// Token: 0x0600EC4E RID: 60494 RVA: 0x001497F0 File Offset: 0x001479F0
		public virtual bool GetTranslateZ()
		{
			return vtkProjectSphereFilter.vtkProjectSphereFilter_GetTranslateZ_06(base.GetCppThis()) != 0;
		}

		// Token: 0x0600EC4F RID: 60495
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProjectSphereFilter_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC50 RID: 60496 RVA: 0x00149818 File Offset: 0x00147A18
		public override int IsA(string type)
		{
			return vtkProjectSphereFilter.vtkProjectSphereFilter_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0600EC51 RID: 60497
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProjectSphereFilter_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC52 RID: 60498 RVA: 0x00149838 File Offset: 0x00147A38
		public new static int IsTypeOf(string type)
		{
			return vtkProjectSphereFilter.vtkProjectSphereFilter_IsTypeOf_08(type);
		}

		// Token: 0x0600EC53 RID: 60499
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectSphereFilter_KeepPolePointsOff_09(HandleRef pThis);

		/// <summary>
		/// Specify whether or not to keep the cells using a point at
		/// a pole. The default is false.
		/// </summary>
		// Token: 0x0600EC54 RID: 60500 RVA: 0x00149852 File Offset: 0x00147A52
		public virtual void KeepPolePointsOff()
		{
			vtkProjectSphereFilter.vtkProjectSphereFilter_KeepPolePointsOff_09(base.GetCppThis());
		}

		// Token: 0x0600EC55 RID: 60501
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectSphereFilter_KeepPolePointsOn_10(HandleRef pThis);

		/// <summary>
		/// Specify whether or not to keep the cells using a point at
		/// a pole. The default is false.
		/// </summary>
		// Token: 0x0600EC56 RID: 60502 RVA: 0x00149861 File Offset: 0x00147A61
		public virtual void KeepPolePointsOn()
		{
			vtkProjectSphereFilter.vtkProjectSphereFilter_KeepPolePointsOn_10(base.GetCppThis());
		}

		// Token: 0x0600EC57 RID: 60503
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProjectSphereFilter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC58 RID: 60504 RVA: 0x00149870 File Offset: 0x00147A70
		public new vtkProjectSphereFilter NewInstance()
		{
			vtkProjectSphereFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProjectSphereFilter.vtkProjectSphereFilter_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProjectSphereFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600EC59 RID: 60505
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProjectSphereFilter_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC5A RID: 60506 RVA: 0x001498CC File Offset: 0x00147ACC
		public new static vtkProjectSphereFilter SafeDownCast(vtkObjectBase o)
		{
			vtkProjectSphereFilter vtkProjectSphereFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProjectSphereFilter.vtkProjectSphereFilter_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProjectSphereFilter = (vtkProjectSphereFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProjectSphereFilter.Register(null);
				}
			}
			return vtkProjectSphereFilter;
		}

		// Token: 0x0600EC5B RID: 60507
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectSphereFilter_SetCenter_14(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the center of the sphere to be split. Default is 0,0,0.
		/// </summary>
		// Token: 0x0600EC5C RID: 60508 RVA: 0x0014994B File Offset: 0x00147B4B
		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkProjectSphereFilter.vtkProjectSphereFilter_SetCenter_14(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600EC5D RID: 60509
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectSphereFilter_SetCenter_15(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the center of the sphere to be split. Default is 0,0,0.
		/// </summary>
		// Token: 0x0600EC5E RID: 60510 RVA: 0x0014995D File Offset: 0x00147B5D
		public virtual void SetCenter(IntPtr _arg)
		{
			vtkProjectSphereFilter.vtkProjectSphereFilter_SetCenter_15(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EC5F RID: 60511
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectSphereFilter_SetKeepPolePoints_16(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify whether or not to keep the cells using a point at
		/// a pole. The default is false.
		/// </summary>
		// Token: 0x0600EC60 RID: 60512 RVA: 0x0014996D File Offset: 0x00147B6D
		public virtual void SetKeepPolePoints(bool _arg)
		{
			vtkProjectSphereFilter.vtkProjectSphereFilter_SetKeepPolePoints_16(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600EC61 RID: 60513
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectSphereFilter_SetTranslateZ_17(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify whether (true) or not to translate the points in the projected
		/// transformation such that the input point with the smallest
		/// radius is at 0. The default is false.
		/// </summary>
		// Token: 0x0600EC62 RID: 60514 RVA: 0x00149985 File Offset: 0x00147B85
		public virtual void SetTranslateZ(bool _arg)
		{
			vtkProjectSphereFilter.vtkProjectSphereFilter_SetTranslateZ_17(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600EC63 RID: 60515
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectSphereFilter_TranslateZOff_18(HandleRef pThis);

		/// <summary>
		/// Specify whether (true) or not to translate the points in the projected
		/// transformation such that the input point with the smallest
		/// radius is at 0. The default is false.
		/// </summary>
		// Token: 0x0600EC64 RID: 60516 RVA: 0x0014999D File Offset: 0x00147B9D
		public virtual void TranslateZOff()
		{
			vtkProjectSphereFilter.vtkProjectSphereFilter_TranslateZOff_18(base.GetCppThis());
		}

		// Token: 0x0600EC65 RID: 60517
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectSphereFilter_TranslateZOn_19(HandleRef pThis);

		/// <summary>
		/// Specify whether (true) or not to translate the points in the projected
		/// transformation such that the input point with the smallest
		/// radius is at 0. The default is false.
		/// </summary>
		// Token: 0x0600EC66 RID: 60518 RVA: 0x001499AC File Offset: 0x00147BAC
		public virtual void TranslateZOn()
		{
			vtkProjectSphereFilter.vtkProjectSphereFilter_TranslateZOn_19(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001141 RID: 4417
		public new const string MRFullTypeName = "Kitware.VTK.vtkProjectSphereFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001142 RID: 4418
		public new static readonly string MRClassNameKey = "class vtkProjectSphereFilter";
	}
}
