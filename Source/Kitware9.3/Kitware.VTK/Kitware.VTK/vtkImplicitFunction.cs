using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImplicitFunction
	/// </summary>
	/// <remarks>
	///    abstract interface for implicit functions
	///
	/// vtkImplicitFunction specifies an abstract interface for implicit
	/// functions. Implicit functions are real valued functions defined in 3D
	/// space, w = F(x,y,z). Two primitive operations are required: the ability to
	/// evaluate the function, and the function gradient at a given point. The
	/// implicit function divides space into three regions: on the surface
	/// (F(x,y,z)=w), outside of the surface (F(x,y,z)&gt;c), and inside the
	/// surface (F(x,y,z)&lt;c). (When c is zero, positive values are outside,
	/// negative values are inside, and zero is on the surface. Note also
	/// that the function gradient points from inside to outside.)
	///
	/// Implicit functions are very powerful. It is possible to represent almost
	/// any type of geometry with the level sets w = const, especially if you use
	/// boolean combinations of implicit functions (see vtkImplicitBoolean).
	///
	/// vtkImplicitFunction provides a mechanism to transform the implicit
	/// function(s) via a vtkAbstractTransform.  This capability can be used to
	/// translate, orient, scale, or warp implicit functions.  For example,
	/// a sphere implicit function can be transformed into an oriented ellipse.
	///
	/// @warning
	/// The transformation transforms a point into the space of the implicit
	/// function (i.e., the model space). Typically we want to transform the
	/// implicit model into world coordinates. In this case the inverse of the
	/// transformation is required.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAbstractTransform vtkSphere vtkCylinder vtkImplicitBoolean vtkPlane
	/// vtkPlanes vtkQuadric vtkImplicitVolume vtkSampleFunction vtkCutter
	/// vtkClipPolyData
	/// </seealso>
	// Token: 0x02000974 RID: 2420
	public abstract class vtkImplicitFunction : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060193B8 RID: 103352 RVA: 0x0023271F File Offset: 0x0023091F
		static vtkImplicitFunction()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImplicitFunction.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitFunction"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060193B9 RID: 103353 RVA: 0x00232747 File Offset: 0x00230947
		public vtkImplicitFunction(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060193BA RID: 103354 RVA: 0x00232755 File Offset: 0x00230955
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060193BB RID: 103355
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitFunction_EvaluateFunction_01(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Evaluate function at position x-y-z and return value.  You should
		/// generally not call this method directly, you should use
		/// FunctionValue() instead.  This method must be implemented by
		/// any derived class.
		/// </summary>
		// Token: 0x060193BC RID: 103356 RVA: 0x00232760 File Offset: 0x00230960
		public virtual double EvaluateFunction(IntPtr x)
		{
			return vtkImplicitFunction.vtkImplicitFunction_EvaluateFunction_01(base.GetCppThis(), x);
		}

		// Token: 0x060193BD RID: 103357
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitFunction_EvaluateFunction_02(HandleRef pThis, HandleRef input, HandleRef output);

		/// <summary>
		/// Evaluate function at position x-y-z and return value.  You should
		/// generally not call this method directly, you should use
		/// FunctionValue() instead.  This method must be implemented by
		/// any derived class.
		/// </summary>
		// Token: 0x060193BE RID: 103358 RVA: 0x00232780 File Offset: 0x00230980
		public virtual void EvaluateFunction(vtkDataArray input, vtkDataArray output)
		{
			vtkImplicitFunction.vtkImplicitFunction_EvaluateFunction_02(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x060193BF RID: 103359
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitFunction_EvaluateFunction_03(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Evaluate function at position x-y-z and return value.  You should
		/// generally not call this method directly, you should use
		/// FunctionValue() instead.  This method must be implemented by
		/// any derived class.
		/// </summary>
		// Token: 0x060193C0 RID: 103360 RVA: 0x002327C4 File Offset: 0x002309C4
		public virtual double EvaluateFunction(double x, double y, double z)
		{
			return vtkImplicitFunction.vtkImplicitFunction_EvaluateFunction_03(base.GetCppThis(), x, y, z);
		}

		// Token: 0x060193C1 RID: 103361
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitFunction_EvaluateGradient_04(HandleRef pThis, IntPtr x, IntPtr g);

		/// <summary>
		/// Evaluate function gradient at position x-y-z and pass back vector.
		/// You should generally not call this method directly, you should use
		/// FunctionGradient() instead.  This method must be implemented by
		/// any derived class.
		/// </summary>
		// Token: 0x060193C2 RID: 103362 RVA: 0x002327E6 File Offset: 0x002309E6
		public virtual void EvaluateGradient(IntPtr x, IntPtr g)
		{
			vtkImplicitFunction.vtkImplicitFunction_EvaluateGradient_04(base.GetCppThis(), x, g);
		}

		// Token: 0x060193C3 RID: 103363
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitFunction_FunctionGradient_05(HandleRef pThis, IntPtr x, IntPtr g);

		/// <summary>
		/// Evaluate function gradient at position x-y-z and pass back vector. Point
		/// x[3] is transformed through transform (if provided).
		/// </summary>
		// Token: 0x060193C4 RID: 103364 RVA: 0x002327F7 File Offset: 0x002309F7
		public void FunctionGradient(IntPtr x, IntPtr g)
		{
			vtkImplicitFunction.vtkImplicitFunction_FunctionGradient_05(base.GetCppThis(), x, g);
		}

		// Token: 0x060193C5 RID: 103365
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitFunction_FunctionGradient_06(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Evaluate function gradient at position x-y-z and pass back vector. Point
		/// x[3] is transformed through transform (if provided).
		/// </summary>
		// Token: 0x060193C6 RID: 103366 RVA: 0x00232808 File Offset: 0x00230A08
		public double[] FunctionGradient(IntPtr x)
		{
			IntPtr intPtr = vtkImplicitFunction.vtkImplicitFunction_FunctionGradient_06(base.GetCppThis(), x);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060193C7 RID: 103367
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitFunction_FunctionGradient_07(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Evaluate function gradient at position x-y-z and pass back vector. Point
		/// x[3] is transformed through transform (if provided).
		/// </summary>
		// Token: 0x060193C8 RID: 103368 RVA: 0x00232854 File Offset: 0x00230A54
		public double[] FunctionGradient(double x, double y, double z)
		{
			IntPtr intPtr = vtkImplicitFunction.vtkImplicitFunction_FunctionGradient_07(base.GetCppThis(), x, y, z);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060193C9 RID: 103369
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitFunction_FunctionValue_08(HandleRef pThis, HandleRef input, HandleRef output);

		/// <summary>
		/// Evaluate function at position x-y-z and return value. Point x[3] is
		/// transformed through transform (if provided).
		/// </summary>
		// Token: 0x060193CA RID: 103370 RVA: 0x002328A0 File Offset: 0x00230AA0
		public virtual void FunctionValue(vtkDataArray input, vtkDataArray output)
		{
			vtkImplicitFunction.vtkImplicitFunction_FunctionValue_08(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x060193CB RID: 103371
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitFunction_FunctionValue_09(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Evaluate function at position x-y-z and return value. Point x[3] is
		/// transformed through transform (if provided).
		/// </summary>
		// Token: 0x060193CC RID: 103372 RVA: 0x002328E4 File Offset: 0x00230AE4
		public double FunctionValue(IntPtr x)
		{
			return vtkImplicitFunction.vtkImplicitFunction_FunctionValue_09(base.GetCppThis(), x);
		}

		// Token: 0x060193CD RID: 103373
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitFunction_FunctionValue_10(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Evaluate function at position x-y-z and return value. Point x[3] is
		/// transformed through transform (if provided).
		/// </summary>
		// Token: 0x060193CE RID: 103374 RVA: 0x00232904 File Offset: 0x00230B04
		public double FunctionValue(double x, double y, double z)
		{
			return vtkImplicitFunction.vtkImplicitFunction_FunctionValue_10(base.GetCppThis(), x, y, z);
		}

		// Token: 0x060193CF RID: 103375
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkImplicitFunction_GetMTime_11(HandleRef pThis);

		/// <summary>
		/// Overload standard modified time function. If Transform is modified,
		/// then this object is modified as well.
		/// </summary>
		// Token: 0x060193D0 RID: 103376 RVA: 0x00232928 File Offset: 0x00230B28
		public override ulong GetMTime()
		{
			return vtkImplicitFunction.vtkImplicitFunction_GetMTime_11(base.GetCppThis());
		}

		// Token: 0x060193D1 RID: 103377
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitFunction_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060193D2 RID: 103378 RVA: 0x00232948 File Offset: 0x00230B48
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImplicitFunction.vtkImplicitFunction_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x060193D3 RID: 103379
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitFunction_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060193D4 RID: 103380 RVA: 0x00232968 File Offset: 0x00230B68
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImplicitFunction.vtkImplicitFunction_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x060193D5 RID: 103381
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitFunction_GetTransform_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get a transformation to apply to input points before
		/// executing the implicit function.
		/// </summary>
		// Token: 0x060193D6 RID: 103382 RVA: 0x00232984 File Offset: 0x00230B84
		public virtual vtkAbstractTransform GetTransform()
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitFunction.vtkImplicitFunction_GetTransform_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractTransform = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractTransform.Register(null);
				}
			}
			return vtkAbstractTransform;
		}

		// Token: 0x060193D7 RID: 103383
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitFunction_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060193D8 RID: 103384 RVA: 0x002329F4 File Offset: 0x00230BF4
		public override int IsA(string type)
		{
			return vtkImplicitFunction.vtkImplicitFunction_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x060193D9 RID: 103385
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitFunction_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060193DA RID: 103386 RVA: 0x00232A14 File Offset: 0x00230C14
		public new static int IsTypeOf(string type)
		{
			return vtkImplicitFunction.vtkImplicitFunction_IsTypeOf_16(type);
		}

		// Token: 0x060193DB RID: 103387
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitFunction_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060193DC RID: 103388 RVA: 0x00232A30 File Offset: 0x00230C30
		public new vtkImplicitFunction NewInstance()
		{
			vtkImplicitFunction result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitFunction.vtkImplicitFunction_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060193DD RID: 103389
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitFunction_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060193DE RID: 103390 RVA: 0x00232A8C File Offset: 0x00230C8C
		public new static vtkImplicitFunction SafeDownCast(vtkObjectBase o)
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitFunction.vtkImplicitFunction_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitFunction = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitFunction.Register(null);
				}
			}
			return vtkImplicitFunction;
		}

		// Token: 0x060193DF RID: 103391
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitFunction_SetTransform_19(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get a transformation to apply to input points before
		/// executing the implicit function.
		/// </summary>
		// Token: 0x060193E0 RID: 103392 RVA: 0x00232B0C File Offset: 0x00230D0C
		public virtual void SetTransform(vtkAbstractTransform arg0)
		{
			vtkImplicitFunction.vtkImplicitFunction_SetTransform_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060193E1 RID: 103393
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitFunction_SetTransform_20(HandleRef pThis, IntPtr elements);

		/// <summary>
		/// Set/Get a transformation to apply to input points before
		/// executing the implicit function.
		/// </summary>
		// Token: 0x060193E2 RID: 103394 RVA: 0x00232B3B File Offset: 0x00230D3B
		public virtual void SetTransform(IntPtr elements)
		{
			vtkImplicitFunction.vtkImplicitFunction_SetTransform_20(base.GetCppThis(), elements);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BA1 RID: 7073
		public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitFunction";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BA2 RID: 7074
		public new static readonly string MRClassNameKey = "class vtkImplicitFunction";
	}
}
