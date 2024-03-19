using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSphere
	/// </summary>
	/// <remarks>
	///    implicit function for a sphere
	///
	/// vtkSphere computes the implicit function and/or gradient for a sphere.
	/// vtkSphere is a concrete implementation of vtkImplicitFunction. Additional
	/// methods are available for sphere-related computations, such as computing
	/// bounding spheres for a set of points, or set of spheres.
	/// </remarks>
	// Token: 0x02000AC3 RID: 2755
	public class vtkSphere : vtkImplicitFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601CFE0 RID: 118752 RVA: 0x0028E207 File Offset: 0x0028C407
		static vtkSphere()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSphere.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSphere"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601CFE1 RID: 118753 RVA: 0x0028E22F File Offset: 0x0028C42F
		public vtkSphere(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601CFE2 RID: 118754
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphere_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct sphere with center at (0,0,0) and radius=0.5.
		/// </summary>
		// Token: 0x0601CFE3 RID: 118755 RVA: 0x0028E240 File Offset: 0x0028C440
		public new static vtkSphere New()
		{
			vtkSphere result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphere.vtkSphere_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphere)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct sphere with center at (0,0,0) and radius=0.5.
		/// </summary>
		// Token: 0x0601CFE4 RID: 118756 RVA: 0x0028E294 File Offset: 0x0028C494
		public vtkSphere() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSphere.vtkSphere_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601CFE5 RID: 118757 RVA: 0x0028E2D8 File Offset: 0x0028C4D8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601CFE6 RID: 118758
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphere_ComputeBoundingSphere_01(IntPtr pts, long numPts, IntPtr sphere, IntPtr hints);

		/// <summary>
		/// Create a bounding sphere from a set of points. The set of points is
		/// defined by an array of doubles, in the order of x-y-z (which repeats for
		/// each point).  An optional hints array provides a guess for the initial
		/// bounding sphere; the two values in the hints array are the two points
		/// expected to be the furthest apart. The output sphere consists of a
		/// center (x-y-z) and a radius.
		/// </summary>
		// Token: 0x0601CFE7 RID: 118759 RVA: 0x0028E2E3 File Offset: 0x0028C4E3
		public static void ComputeBoundingSphere(IntPtr pts, long numPts, IntPtr sphere, IntPtr hints)
		{
			vtkSphere.vtkSphere_ComputeBoundingSphere_01(pts, numPts, sphere, hints);
		}

		// Token: 0x0601CFE8 RID: 118760
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSphere_Evaluate_02(IntPtr center, double R, IntPtr x);

		/// <summary>
		/// Quick evaluation of the sphere equation ((x-x0)^2 + (y-y0)^2 + (z-z0)^2) - R^2.
		/// </summary>
		// Token: 0x0601CFE9 RID: 118761 RVA: 0x0028E2F0 File Offset: 0x0028C4F0
		public static double Evaluate(IntPtr center, double R, IntPtr x)
		{
			return vtkSphere.vtkSphere_Evaluate_02(center, R, x);
		}

		// Token: 0x0601CFEA RID: 118762
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSphere_EvaluateFunction_03(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Evaluate sphere equation ((x-x0)^2 + (y-y0)^2 + (z-z0)^2) - R^2.
		/// </summary>
		// Token: 0x0601CFEB RID: 118763 RVA: 0x0028E30C File Offset: 0x0028C50C
		public override double EvaluateFunction(IntPtr x)
		{
			return vtkSphere.vtkSphere_EvaluateFunction_03(base.GetCppThis(), x);
		}

		// Token: 0x0601CFEC RID: 118764
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphere_EvaluateGradient_04(HandleRef pThis, IntPtr x, IntPtr n);

		/// <summary>
		/// Evaluate sphere gradient.
		/// </summary>
		// Token: 0x0601CFED RID: 118765 RVA: 0x0028E32C File Offset: 0x0028C52C
		public override void EvaluateGradient(IntPtr x, IntPtr n)
		{
			vtkSphere.vtkSphere_EvaluateGradient_04(base.GetCppThis(), x, n);
		}

		// Token: 0x0601CFEE RID: 118766
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphere_GetCenter_05(HandleRef pThis);

		/// <summary>
		/// Set / get the center of the sphere. The default is (0,0,0).
		/// </summary>
		// Token: 0x0601CFEF RID: 118767 RVA: 0x0028E340 File Offset: 0x0028C540
		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkSphere.vtkSphere_GetCenter_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601CFF0 RID: 118768
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphere_GetCenter_06(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set / get the center of the sphere. The default is (0,0,0).
		/// </summary>
		// Token: 0x0601CFF1 RID: 118769 RVA: 0x0028E388 File Offset: 0x0028C588
		public virtual void GetCenter(IntPtr data)
		{
			vtkSphere.vtkSphere_GetCenter_06(base.GetCppThis(), data);
		}

		// Token: 0x0601CFF2 RID: 118770
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSphere_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CFF3 RID: 118771 RVA: 0x0028E398 File Offset: 0x0028C598
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSphere.vtkSphere_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0601CFF4 RID: 118772
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSphere_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CFF5 RID: 118773 RVA: 0x0028E3B8 File Offset: 0x0028C5B8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSphere.vtkSphere_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0601CFF6 RID: 118774
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSphere_GetRadius_09(HandleRef pThis);

		/// <summary>
		/// Set / get the radius of the sphere. The default is 0.5.
		/// </summary>
		// Token: 0x0601CFF7 RID: 118775 RVA: 0x0028E3D4 File Offset: 0x0028C5D4
		public virtual double GetRadius()
		{
			return vtkSphere.vtkSphere_GetRadius_09(base.GetCppThis());
		}

		// Token: 0x0601CFF8 RID: 118776
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphere_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CFF9 RID: 118777 RVA: 0x0028E3F4 File Offset: 0x0028C5F4
		public override int IsA(string type)
		{
			return vtkSphere.vtkSphere_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x0601CFFA RID: 118778
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphere_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CFFB RID: 118779 RVA: 0x0028E414 File Offset: 0x0028C614
		public new static int IsTypeOf(string type)
		{
			return vtkSphere.vtkSphere_IsTypeOf_11(type);
		}

		// Token: 0x0601CFFC RID: 118780
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphere_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CFFD RID: 118781 RVA: 0x0028E430 File Offset: 0x0028C630
		public new vtkSphere NewInstance()
		{
			vtkSphere result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphere.vtkSphere_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphere)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601CFFE RID: 118782
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphere_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CFFF RID: 118783 RVA: 0x0028E48C File Offset: 0x0028C68C
		public new static vtkSphere SafeDownCast(vtkObjectBase o)
		{
			vtkSphere vtkSphere = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphere.vtkSphere_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSphere = (vtkSphere)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSphere.Register(null);
				}
			}
			return vtkSphere;
		}

		// Token: 0x0601D000 RID: 118784
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphere_SetCenter_15(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set / get the center of the sphere. The default is (0,0,0).
		/// </summary>
		// Token: 0x0601D001 RID: 118785 RVA: 0x0028E50B File Offset: 0x0028C70B
		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkSphere.vtkSphere_SetCenter_15(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0601D002 RID: 118786
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphere_SetCenter_16(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set / get the center of the sphere. The default is (0,0,0).
		/// </summary>
		// Token: 0x0601D003 RID: 118787 RVA: 0x0028E51D File Offset: 0x0028C71D
		public virtual void SetCenter(IntPtr _arg)
		{
			vtkSphere.vtkSphere_SetCenter_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0601D004 RID: 118788
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphere_SetRadius_17(HandleRef pThis, double _arg);

		/// <summary>
		/// Set / get the radius of the sphere. The default is 0.5.
		/// </summary>
		// Token: 0x0601D005 RID: 118789 RVA: 0x0028E52D File Offset: 0x0028C72D
		public virtual void SetRadius(double _arg)
		{
			vtkSphere.vtkSphere_SetRadius_17(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EA2 RID: 7842
		public new const string MRFullTypeName = "Kitware.VTK.vtkSphere";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EA3 RID: 7843
		public new static readonly string MRClassNameKey = "class vtkSphere";
	}
}
