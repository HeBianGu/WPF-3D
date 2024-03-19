using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCone
	/// </summary>
	/// <remarks>
	///    implicit function for a cone
	///
	/// vtkCone computes the implicit function and function gradient for a cone.
	/// vtkCone is a concrete implementation of vtkImplicitFunction. The cone vertex
	/// is located at the origin with axis of rotation coincident with x-axis. (Use
	/// the superclass' vtkImplicitFunction transformation matrix if necessary to
	/// reposition.) The angle specifies the angle between the axis of rotation
	/// and the side of the cone.
	///
	/// @warning
	/// The cone is infinite in extent. To truncate the cone use the
	/// vtkImplicitBoolean in combination with clipping planes.
	/// </remarks>
	// Token: 0x02000A31 RID: 2609
	public class vtkCone : vtkImplicitFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B2CC RID: 111308 RVA: 0x0025F57B File Offset: 0x0025D77B
		static vtkCone()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCone.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCone"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B2CD RID: 111309 RVA: 0x0025F5A3 File Offset: 0x0025D7A3
		public vtkCone(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B2CE RID: 111310
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCone_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct cone with angle of 45 degrees.
		/// </summary>
		// Token: 0x0601B2CF RID: 111311 RVA: 0x0025F5B4 File Offset: 0x0025D7B4
		public new static vtkCone New()
		{
			vtkCone result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCone.vtkCone_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCone)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct cone with angle of 45 degrees.
		/// </summary>
		// Token: 0x0601B2D0 RID: 111312 RVA: 0x0025F608 File Offset: 0x0025D808
		public vtkCone() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCone.vtkCone_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B2D1 RID: 111313 RVA: 0x0025F64C File Offset: 0x0025D84C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B2D2 RID: 111314
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCone_EvaluateFunction_01(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Evaluate cone equation.
		/// </summary>
		// Token: 0x0601B2D3 RID: 111315 RVA: 0x0025F658 File Offset: 0x0025D858
		public override double EvaluateFunction(IntPtr x)
		{
			return vtkCone.vtkCone_EvaluateFunction_01(base.GetCppThis(), x);
		}

		// Token: 0x0601B2D4 RID: 111316
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCone_EvaluateGradient_02(HandleRef pThis, IntPtr x, IntPtr g);

		/// <summary>
		/// Evaluate cone normal.
		/// </summary>
		// Token: 0x0601B2D5 RID: 111317 RVA: 0x0025F678 File Offset: 0x0025D878
		public override void EvaluateGradient(IntPtr x, IntPtr g)
		{
			vtkCone.vtkCone_EvaluateGradient_02(base.GetCppThis(), x, g);
		}

		// Token: 0x0601B2D6 RID: 111318
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCone_GetAngle_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the cone angle (expressed in degrees).
		/// </summary>
		// Token: 0x0601B2D7 RID: 111319 RVA: 0x0025F68C File Offset: 0x0025D88C
		public virtual double GetAngle()
		{
			return vtkCone.vtkCone_GetAngle_03(base.GetCppThis());
		}

		// Token: 0x0601B2D8 RID: 111320
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCone_GetAngleMaxValue_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the cone angle (expressed in degrees).
		/// </summary>
		// Token: 0x0601B2D9 RID: 111321 RVA: 0x0025F6AC File Offset: 0x0025D8AC
		public virtual double GetAngleMaxValue()
		{
			return vtkCone.vtkCone_GetAngleMaxValue_04(base.GetCppThis());
		}

		// Token: 0x0601B2DA RID: 111322
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCone_GetAngleMinValue_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the cone angle (expressed in degrees).
		/// </summary>
		// Token: 0x0601B2DB RID: 111323 RVA: 0x0025F6CC File Offset: 0x0025D8CC
		public virtual double GetAngleMinValue()
		{
			return vtkCone.vtkCone_GetAngleMinValue_05(base.GetCppThis());
		}

		// Token: 0x0601B2DC RID: 111324
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCone_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct cone with angle of 45 degrees.
		/// </summary>
		// Token: 0x0601B2DD RID: 111325 RVA: 0x0025F6EC File Offset: 0x0025D8EC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCone.vtkCone_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0601B2DE RID: 111326
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCone_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct cone with angle of 45 degrees.
		/// </summary>
		// Token: 0x0601B2DF RID: 111327 RVA: 0x0025F70C File Offset: 0x0025D90C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCone.vtkCone_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0601B2E0 RID: 111328
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCone_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct cone with angle of 45 degrees.
		/// </summary>
		// Token: 0x0601B2E1 RID: 111329 RVA: 0x0025F728 File Offset: 0x0025D928
		public override int IsA(string type)
		{
			return vtkCone.vtkCone_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0601B2E2 RID: 111330
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCone_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct cone with angle of 45 degrees.
		/// </summary>
		// Token: 0x0601B2E3 RID: 111331 RVA: 0x0025F748 File Offset: 0x0025D948
		public new static int IsTypeOf(string type)
		{
			return vtkCone.vtkCone_IsTypeOf_09(type);
		}

		// Token: 0x0601B2E4 RID: 111332
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCone_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct cone with angle of 45 degrees.
		/// </summary>
		// Token: 0x0601B2E5 RID: 111333 RVA: 0x0025F764 File Offset: 0x0025D964
		public new vtkCone NewInstance()
		{
			vtkCone result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCone.vtkCone_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCone)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B2E6 RID: 111334
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCone_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct cone with angle of 45 degrees.
		/// </summary>
		// Token: 0x0601B2E7 RID: 111335 RVA: 0x0025F7C0 File Offset: 0x0025D9C0
		public new static vtkCone SafeDownCast(vtkObjectBase o)
		{
			vtkCone vtkCone = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCone.vtkCone_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCone = (vtkCone)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCone.Register(null);
				}
			}
			return vtkCone;
		}

		// Token: 0x0601B2E8 RID: 111336
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCone_SetAngle_13(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the cone angle (expressed in degrees).
		/// </summary>
		// Token: 0x0601B2E9 RID: 111337 RVA: 0x0025F83F File Offset: 0x0025DA3F
		public virtual void SetAngle(double _arg)
		{
			vtkCone.vtkCone_SetAngle_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D55 RID: 7509
		public new const string MRFullTypeName = "Kitware.VTK.vtkCone";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D56 RID: 7510
		public new static readonly string MRClassNameKey = "class vtkCone";
	}
}
