using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSpheres
	/// </summary>
	/// <remarks>
	///    implicit function for a set of spheres
	///
	/// vtkSpheres computes the implicit function and function gradient for a set
	/// of spheres. The spheres are combined via a union operation (i.e., the
	/// minimum value from the evaluation of all spheres is taken).
	///
	/// The function value is the distance of a point to the closest sphere, with
	/// negative values interior to the spheres, positive outside the spheres, and
	/// distance=0 on the spheres surface.  The function gradient is the sphere
	/// normal at the function value.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPlanes vtkImplicitBoolean
	/// </seealso>
	// Token: 0x02000AC4 RID: 2756
	public class vtkSpheres : vtkImplicitFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D006 RID: 118790 RVA: 0x0028E53D File Offset: 0x0028C73D
		static vtkSpheres()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSpheres.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSpheres"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D007 RID: 118791 RVA: 0x0028E565 File Offset: 0x0028C765
		public vtkSpheres(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D008 RID: 118792
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpheres_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601D009 RID: 118793 RVA: 0x0028E574 File Offset: 0x0028C774
		public new static vtkSpheres New()
		{
			vtkSpheres result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpheres.vtkSpheres_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSpheres)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601D00A RID: 118794 RVA: 0x0028E5C8 File Offset: 0x0028C7C8
		public vtkSpheres() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSpheres.vtkSpheres_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D00B RID: 118795 RVA: 0x0028E60C File Offset: 0x0028C80C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D00C RID: 118796
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSpheres_EvaluateFunction_01(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Evaluate spheres equations. Return largest value when evaluating all
		/// sphere equations.
		/// </summary>
		// Token: 0x0601D00D RID: 118797 RVA: 0x0028E618 File Offset: 0x0028C818
		public override double EvaluateFunction(IntPtr x)
		{
			return vtkSpheres.vtkSpheres_EvaluateFunction_01(base.GetCppThis(), x);
		}

		// Token: 0x0601D00E RID: 118798
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpheres_EvaluateGradient_02(HandleRef pThis, IntPtr x, IntPtr n);

		/// <summary>
		/// Evaluate spheres gradient. Gradients point towards the outside of the
		/// spheres.
		/// </summary>
		// Token: 0x0601D00F RID: 118799 RVA: 0x0028E638 File Offset: 0x0028C838
		public override void EvaluateGradient(IntPtr x, IntPtr n)
		{
			vtkSpheres.vtkSpheres_EvaluateGradient_02(base.GetCppThis(), x, n);
		}

		// Token: 0x0601D010 RID: 118800
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpheres_GetCenters_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a list of points defining sphere centers.
		/// </summary>
		// Token: 0x0601D011 RID: 118801 RVA: 0x0028E64C File Offset: 0x0028C84C
		public virtual vtkPoints GetCenters()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpheres.vtkSpheres_GetCenters_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		// Token: 0x0601D012 RID: 118802
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSpheres_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601D013 RID: 118803 RVA: 0x0028E6BC File Offset: 0x0028C8BC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSpheres.vtkSpheres_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601D014 RID: 118804
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSpheres_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601D015 RID: 118805 RVA: 0x0028E6DC File Offset: 0x0028C8DC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSpheres.vtkSpheres_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601D016 RID: 118806
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpheres_GetNumberOfSpheres_06(HandleRef pThis);

		/// <summary>
		/// Return the number of spheres in the set of spheres.
		/// </summary>
		// Token: 0x0601D017 RID: 118807 RVA: 0x0028E6F8 File Offset: 0x0028C8F8
		public int GetNumberOfSpheres()
		{
			return vtkSpheres.vtkSpheres_GetNumberOfSpheres_06(base.GetCppThis());
		}

		// Token: 0x0601D018 RID: 118808
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpheres_GetRadii_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a list of radii for the spheres. There is a one-to-one
		/// correspondence between sphere points and sphere radii.
		/// </summary>
		// Token: 0x0601D019 RID: 118809 RVA: 0x0028E718 File Offset: 0x0028C918
		public virtual vtkDataArray GetRadii()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpheres.vtkSpheres_GetRadii_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		// Token: 0x0601D01A RID: 118810
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpheres_GetSphere_08(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create and return a pointer to a vtkSphere object at the ith
		/// position. Asking for a sphere outside the allowable range returns
		/// nullptr.  This method always returns the same object.  Alternatively use
		/// GetSphere(int i, vtkSphere *sphere) to update a user supplied sphere.
		/// </summary>
		// Token: 0x0601D01B RID: 118811 RVA: 0x0028E788 File Offset: 0x0028C988
		public vtkSphere GetSphere(int i)
		{
			vtkSphere vtkSphere = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpheres.vtkSpheres_GetSphere_08(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601D01C RID: 118812
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpheres_GetSphere_09(HandleRef pThis, int i, HandleRef sphere);

		/// <summary>
		/// If i is within the allowable range, mutates the given sphere's
		/// Center and Radius to match the vtkSphere object at the ith
		/// position. Does nothing if i is outside the allowable range.
		/// </summary>
		// Token: 0x0601D01D RID: 118813 RVA: 0x0028E7F8 File Offset: 0x0028C9F8
		public void GetSphere(int i, vtkSphere sphere)
		{
			vtkSpheres.vtkSpheres_GetSphere_09(base.GetCppThis(), i, (sphere == null) ? default(HandleRef) : sphere.GetCppThis());
		}

		// Token: 0x0601D01E RID: 118814
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpheres_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601D01F RID: 118815 RVA: 0x0028E828 File Offset: 0x0028CA28
		public override int IsA(string type)
		{
			return vtkSpheres.vtkSpheres_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x0601D020 RID: 118816
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpheres_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601D021 RID: 118817 RVA: 0x0028E848 File Offset: 0x0028CA48
		public new static int IsTypeOf(string type)
		{
			return vtkSpheres.vtkSpheres_IsTypeOf_11(type);
		}

		// Token: 0x0601D022 RID: 118818
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpheres_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601D023 RID: 118819 RVA: 0x0028E864 File Offset: 0x0028CA64
		public new vtkSpheres NewInstance()
		{
			vtkSpheres result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpheres.vtkSpheres_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSpheres)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D024 RID: 118820
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpheres_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601D025 RID: 118821 RVA: 0x0028E8C0 File Offset: 0x0028CAC0
		public new static vtkSpheres SafeDownCast(vtkObjectBase o)
		{
			vtkSpheres vtkSpheres = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpheres.vtkSpheres_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSpheres = (vtkSpheres)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSpheres.Register(null);
				}
			}
			return vtkSpheres;
		}

		// Token: 0x0601D026 RID: 118822
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpheres_SetCenters_15(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify a list of points defining sphere centers.
		/// </summary>
		// Token: 0x0601D027 RID: 118823 RVA: 0x0028E940 File Offset: 0x0028CB40
		public virtual void SetCenters(vtkPoints arg0)
		{
			vtkSpheres.vtkSpheres_SetCenters_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601D028 RID: 118824
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpheres_SetRadii_16(HandleRef pThis, HandleRef radii);

		/// <summary>
		/// Specify a list of radii for the spheres. There is a one-to-one
		/// correspondence between sphere points and sphere radii.
		/// </summary>
		// Token: 0x0601D029 RID: 118825 RVA: 0x0028E970 File Offset: 0x0028CB70
		public void SetRadii(vtkDataArray radii)
		{
			vtkSpheres.vtkSpheres_SetRadii_16(base.GetCppThis(), (radii == null) ? default(HandleRef) : radii.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EA4 RID: 7844
		public new const string MRFullTypeName = "Kitware.VTK.vtkSpheres";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EA5 RID: 7845
		public new static readonly string MRClassNameKey = "class vtkSpheres";
	}
}
