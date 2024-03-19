using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBrownianPoints
	/// </summary>
	/// <remarks>
	///    assign random vector to points
	///
	/// vtkBrownianPoints is a filter object that assigns a random vector (i.e.,
	/// magnitude and direction) to each point. The minimum and maximum speed
	/// values can be controlled by the user.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRandomAttributeGenerator
	/// </seealso>
	// Token: 0x0200087A RID: 2170
	public class vtkBrownianPoints : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016832 RID: 92210 RVA: 0x001FACE1 File Offset: 0x001F8EE1
		static vtkBrownianPoints()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBrownianPoints.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBrownianPoints"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016833 RID: 92211 RVA: 0x001FAD09 File Offset: 0x001F8F09
		public vtkBrownianPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016834 RID: 92212
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBrownianPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create instance with minimum speed 0.0, maximum speed 1.0.
		/// </summary>
		// Token: 0x06016835 RID: 92213 RVA: 0x001FAD18 File Offset: 0x001F8F18
		public new static vtkBrownianPoints New()
		{
			vtkBrownianPoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBrownianPoints.vtkBrownianPoints_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBrownianPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Create instance with minimum speed 0.0, maximum speed 1.0.
		/// </summary>
		// Token: 0x06016836 RID: 92214 RVA: 0x001FAD6C File Offset: 0x001F8F6C
		public vtkBrownianPoints() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBrownianPoints.vtkBrownianPoints_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016837 RID: 92215 RVA: 0x001FADB0 File Offset: 0x001F8FB0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016838 RID: 92216
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkBrownianPoints_GetMaximumSpeed_01(HandleRef pThis);

		/// <summary>
		/// Set the maximum speed value.
		/// </summary>
		// Token: 0x06016839 RID: 92217 RVA: 0x001FADBC File Offset: 0x001F8FBC
		public virtual double GetMaximumSpeed()
		{
			return vtkBrownianPoints.vtkBrownianPoints_GetMaximumSpeed_01(base.GetCppThis());
		}

		// Token: 0x0601683A RID: 92218
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkBrownianPoints_GetMaximumSpeedMaxValue_02(HandleRef pThis);

		/// <summary>
		/// Set the maximum speed value.
		/// </summary>
		// Token: 0x0601683B RID: 92219 RVA: 0x001FADDC File Offset: 0x001F8FDC
		public virtual double GetMaximumSpeedMaxValue()
		{
			return vtkBrownianPoints.vtkBrownianPoints_GetMaximumSpeedMaxValue_02(base.GetCppThis());
		}

		// Token: 0x0601683C RID: 92220
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkBrownianPoints_GetMaximumSpeedMinValue_03(HandleRef pThis);

		/// <summary>
		/// Set the maximum speed value.
		/// </summary>
		// Token: 0x0601683D RID: 92221 RVA: 0x001FADFC File Offset: 0x001F8FFC
		public virtual double GetMaximumSpeedMinValue()
		{
			return vtkBrownianPoints.vtkBrownianPoints_GetMaximumSpeedMinValue_03(base.GetCppThis());
		}

		// Token: 0x0601683E RID: 92222
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkBrownianPoints_GetMinimumSpeed_04(HandleRef pThis);

		/// <summary>
		/// Set the minimum speed value.
		/// </summary>
		// Token: 0x0601683F RID: 92223 RVA: 0x001FAE1C File Offset: 0x001F901C
		public virtual double GetMinimumSpeed()
		{
			return vtkBrownianPoints.vtkBrownianPoints_GetMinimumSpeed_04(base.GetCppThis());
		}

		// Token: 0x06016840 RID: 92224
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkBrownianPoints_GetMinimumSpeedMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Set the minimum speed value.
		/// </summary>
		// Token: 0x06016841 RID: 92225 RVA: 0x001FAE3C File Offset: 0x001F903C
		public virtual double GetMinimumSpeedMaxValue()
		{
			return vtkBrownianPoints.vtkBrownianPoints_GetMinimumSpeedMaxValue_05(base.GetCppThis());
		}

		// Token: 0x06016842 RID: 92226
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkBrownianPoints_GetMinimumSpeedMinValue_06(HandleRef pThis);

		/// <summary>
		/// Set the minimum speed value.
		/// </summary>
		// Token: 0x06016843 RID: 92227 RVA: 0x001FAE5C File Offset: 0x001F905C
		public virtual double GetMinimumSpeedMinValue()
		{
			return vtkBrownianPoints.vtkBrownianPoints_GetMinimumSpeedMinValue_06(base.GetCppThis());
		}

		// Token: 0x06016844 RID: 92228
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBrownianPoints_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Create instance with minimum speed 0.0, maximum speed 1.0.
		/// </summary>
		// Token: 0x06016845 RID: 92229 RVA: 0x001FAE7C File Offset: 0x001F907C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBrownianPoints.vtkBrownianPoints_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06016846 RID: 92230
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBrownianPoints_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Create instance with minimum speed 0.0, maximum speed 1.0.
		/// </summary>
		// Token: 0x06016847 RID: 92231 RVA: 0x001FAE9C File Offset: 0x001F909C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBrownianPoints.vtkBrownianPoints_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06016848 RID: 92232
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBrownianPoints_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Create instance with minimum speed 0.0, maximum speed 1.0.
		/// </summary>
		// Token: 0x06016849 RID: 92233 RVA: 0x001FAEB8 File Offset: 0x001F90B8
		public override int IsA(string type)
		{
			return vtkBrownianPoints.vtkBrownianPoints_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0601684A RID: 92234
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBrownianPoints_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Create instance with minimum speed 0.0, maximum speed 1.0.
		/// </summary>
		// Token: 0x0601684B RID: 92235 RVA: 0x001FAED8 File Offset: 0x001F90D8
		public new static int IsTypeOf(string type)
		{
			return vtkBrownianPoints.vtkBrownianPoints_IsTypeOf_10(type);
		}

		// Token: 0x0601684C RID: 92236
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBrownianPoints_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create instance with minimum speed 0.0, maximum speed 1.0.
		/// </summary>
		// Token: 0x0601684D RID: 92237 RVA: 0x001FAEF4 File Offset: 0x001F90F4
		public new vtkBrownianPoints NewInstance()
		{
			vtkBrownianPoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBrownianPoints.vtkBrownianPoints_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBrownianPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601684E RID: 92238
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBrownianPoints_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create instance with minimum speed 0.0, maximum speed 1.0.
		/// </summary>
		// Token: 0x0601684F RID: 92239 RVA: 0x001FAF50 File Offset: 0x001F9150
		public new static vtkBrownianPoints SafeDownCast(vtkObjectBase o)
		{
			vtkBrownianPoints vtkBrownianPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBrownianPoints.vtkBrownianPoints_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBrownianPoints = (vtkBrownianPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBrownianPoints.Register(null);
				}
			}
			return vtkBrownianPoints;
		}

		// Token: 0x06016850 RID: 92240
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrownianPoints_SetMaximumSpeed_14(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the maximum speed value.
		/// </summary>
		// Token: 0x06016851 RID: 92241 RVA: 0x001FAFCF File Offset: 0x001F91CF
		public virtual void SetMaximumSpeed(double _arg)
		{
			vtkBrownianPoints.vtkBrownianPoints_SetMaximumSpeed_14(base.GetCppThis(), _arg);
		}

		// Token: 0x06016852 RID: 92242
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrownianPoints_SetMinimumSpeed_15(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the minimum speed value.
		/// </summary>
		// Token: 0x06016853 RID: 92243 RVA: 0x001FAFDF File Offset: 0x001F91DF
		public virtual void SetMinimumSpeed(double _arg)
		{
			vtkBrownianPoints.vtkBrownianPoints_SetMinimumSpeed_15(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400194C RID: 6476
		public new const string MRFullTypeName = "Kitware.VTK.vtkBrownianPoints";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400194D RID: 6477
		public new static readonly string MRClassNameKey = "class vtkBrownianPoints";
	}
}
