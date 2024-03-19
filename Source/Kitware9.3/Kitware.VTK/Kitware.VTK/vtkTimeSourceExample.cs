using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTimeSource
	/// </summary>
	/// <remarks>
	///    creates a simple time varying data set.
	///
	/// Creates a small easily understood time varying data set for testing.
	/// The output is a vtkUntructuredGrid in which the point and cell values vary
	/// over time in a sin wave. The analytic ivar controls whether the output
	/// corresponds to a step function over time or is continuous.
	/// The X and Y Amplitude ivars make the output move in the X and Y directions
	/// over time. The Growing ivar makes the number of cells in the output grow
	/// and then shrink over time.
	/// </remarks>
	// Token: 0x020008F2 RID: 2290
	public class vtkTimeSourceExample : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017A97 RID: 96919 RVA: 0x00212D0F File Offset: 0x00210F0F
		static vtkTimeSourceExample()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTimeSourceExample.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTimeSourceExample"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017A98 RID: 96920 RVA: 0x00212D37 File Offset: 0x00210F37
		public vtkTimeSourceExample(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017A99 RID: 96921
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTimeSourceExample_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017A9A RID: 96922 RVA: 0x00212D48 File Offset: 0x00210F48
		public new static vtkTimeSourceExample New()
		{
			vtkTimeSourceExample result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTimeSourceExample.vtkTimeSourceExample_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTimeSourceExample)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017A9B RID: 96923 RVA: 0x00212D9C File Offset: 0x00210F9C
		public vtkTimeSourceExample() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTimeSourceExample.vtkTimeSourceExample_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017A9C RID: 96924 RVA: 0x00212DE0 File Offset: 0x00210FE0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017A9D RID: 96925
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTimeSourceExample_AnalyticOff_01(HandleRef pThis);

		/// <summary>
		/// When off (the default) this source produces a discrete set of values.
		/// When on, this source produces a value analytically for any queried time.
		/// </summary>
		// Token: 0x06017A9E RID: 96926 RVA: 0x00212DEB File Offset: 0x00210FEB
		public virtual void AnalyticOff()
		{
			vtkTimeSourceExample.vtkTimeSourceExample_AnalyticOff_01(base.GetCppThis());
		}

		// Token: 0x06017A9F RID: 96927
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTimeSourceExample_AnalyticOn_02(HandleRef pThis);

		/// <summary>
		/// When off (the default) this source produces a discrete set of values.
		/// When on, this source produces a value analytically for any queried time.
		/// </summary>
		// Token: 0x06017AA0 RID: 96928 RVA: 0x00212DFA File Offset: 0x00210FFA
		public virtual void AnalyticOn()
		{
			vtkTimeSourceExample.vtkTimeSourceExample_AnalyticOn_02(base.GetCppThis());
		}

		// Token: 0x06017AA1 RID: 96929
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTimeSourceExample_GetAnalytic_03(HandleRef pThis);

		/// <summary>
		/// When off (the default) this source produces a discrete set of values.
		/// When on, this source produces a value analytically for any queried time.
		/// </summary>
		// Token: 0x06017AA2 RID: 96930 RVA: 0x00212E0C File Offset: 0x0021100C
		public virtual int GetAnalytic()
		{
			return vtkTimeSourceExample.vtkTimeSourceExample_GetAnalytic_03(base.GetCppThis());
		}

		// Token: 0x06017AA3 RID: 96931
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTimeSourceExample_GetAnalyticMaxValue_04(HandleRef pThis);

		/// <summary>
		/// When off (the default) this source produces a discrete set of values.
		/// When on, this source produces a value analytically for any queried time.
		/// </summary>
		// Token: 0x06017AA4 RID: 96932 RVA: 0x00212E2C File Offset: 0x0021102C
		public virtual int GetAnalyticMaxValue()
		{
			return vtkTimeSourceExample.vtkTimeSourceExample_GetAnalyticMaxValue_04(base.GetCppThis());
		}

		// Token: 0x06017AA5 RID: 96933
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTimeSourceExample_GetAnalyticMinValue_05(HandleRef pThis);

		/// <summary>
		/// When off (the default) this source produces a discrete set of values.
		/// When on, this source produces a value analytically for any queried time.
		/// </summary>
		// Token: 0x06017AA6 RID: 96934 RVA: 0x00212E4C File Offset: 0x0021104C
		public virtual int GetAnalyticMinValue()
		{
			return vtkTimeSourceExample.vtkTimeSourceExample_GetAnalyticMinValue_05(base.GetCppThis());
		}

		// Token: 0x06017AA7 RID: 96935
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTimeSourceExample_GetGrowing_06(HandleRef pThis);

		/// <summary>
		/// When off (the default) this produces a single cell data set.
		/// When on the number of cells (in the Y direction) grows
		/// and shrinks over time along a hat function.
		/// </summary>
		// Token: 0x06017AA8 RID: 96936 RVA: 0x00212E6C File Offset: 0x0021106C
		public virtual int GetGrowing()
		{
			return vtkTimeSourceExample.vtkTimeSourceExample_GetGrowing_06(base.GetCppThis());
		}

		// Token: 0x06017AA9 RID: 96937
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTimeSourceExample_GetGrowingMaxValue_07(HandleRef pThis);

		/// <summary>
		/// When off (the default) this produces a single cell data set.
		/// When on the number of cells (in the Y direction) grows
		/// and shrinks over time along a hat function.
		/// </summary>
		// Token: 0x06017AAA RID: 96938 RVA: 0x00212E8C File Offset: 0x0021108C
		public virtual int GetGrowingMaxValue()
		{
			return vtkTimeSourceExample.vtkTimeSourceExample_GetGrowingMaxValue_07(base.GetCppThis());
		}

		// Token: 0x06017AAB RID: 96939
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTimeSourceExample_GetGrowingMinValue_08(HandleRef pThis);

		/// <summary>
		/// When off (the default) this produces a single cell data set.
		/// When on the number of cells (in the Y direction) grows
		/// and shrinks over time along a hat function.
		/// </summary>
		// Token: 0x06017AAC RID: 96940 RVA: 0x00212EAC File Offset: 0x002110AC
		public virtual int GetGrowingMinValue()
		{
			return vtkTimeSourceExample.vtkTimeSourceExample_GetGrowingMinValue_08(base.GetCppThis());
		}

		// Token: 0x06017AAD RID: 96941
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTimeSourceExample_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017AAE RID: 96942 RVA: 0x00212ECC File Offset: 0x002110CC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTimeSourceExample.vtkTimeSourceExample_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x06017AAF RID: 96943
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTimeSourceExample_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017AB0 RID: 96944 RVA: 0x00212EEC File Offset: 0x002110EC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTimeSourceExample.vtkTimeSourceExample_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x06017AB1 RID: 96945
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTimeSourceExample_GetXAmplitude_11(HandleRef pThis);

		/// <summary>
		/// When 0.0 (the default) this produces a data set that is stationary.
		/// When on the data set moves in the X/Y plane over a sin wave over time,
		/// amplified by the value.
		/// </summary>
		// Token: 0x06017AB2 RID: 96946 RVA: 0x00212F08 File Offset: 0x00211108
		public virtual double GetXAmplitude()
		{
			return vtkTimeSourceExample.vtkTimeSourceExample_GetXAmplitude_11(base.GetCppThis());
		}

		// Token: 0x06017AB3 RID: 96947
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTimeSourceExample_GetYAmplitude_12(HandleRef pThis);

		/// <summary>
		/// When 0.0 (the default) this produces a data set that is stationary.
		/// When on the data set moves in the X/Y plane over a sin wave over time,
		/// amplified by the value.
		/// </summary>
		// Token: 0x06017AB4 RID: 96948 RVA: 0x00212F28 File Offset: 0x00211128
		public virtual double GetYAmplitude()
		{
			return vtkTimeSourceExample.vtkTimeSourceExample_GetYAmplitude_12(base.GetCppThis());
		}

		// Token: 0x06017AB5 RID: 96949
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTimeSourceExample_GrowingOff_13(HandleRef pThis);

		/// <summary>
		/// When off (the default) this produces a single cell data set.
		/// When on the number of cells (in the Y direction) grows
		/// and shrinks over time along a hat function.
		/// </summary>
		// Token: 0x06017AB6 RID: 96950 RVA: 0x00212F47 File Offset: 0x00211147
		public virtual void GrowingOff()
		{
			vtkTimeSourceExample.vtkTimeSourceExample_GrowingOff_13(base.GetCppThis());
		}

		// Token: 0x06017AB7 RID: 96951
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTimeSourceExample_GrowingOn_14(HandleRef pThis);

		/// <summary>
		/// When off (the default) this produces a single cell data set.
		/// When on the number of cells (in the Y direction) grows
		/// and shrinks over time along a hat function.
		/// </summary>
		// Token: 0x06017AB8 RID: 96952 RVA: 0x00212F56 File Offset: 0x00211156
		public virtual void GrowingOn()
		{
			vtkTimeSourceExample.vtkTimeSourceExample_GrowingOn_14(base.GetCppThis());
		}

		// Token: 0x06017AB9 RID: 96953
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTimeSourceExample_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017ABA RID: 96954 RVA: 0x00212F68 File Offset: 0x00211168
		public override int IsA(string type)
		{
			return vtkTimeSourceExample.vtkTimeSourceExample_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x06017ABB RID: 96955
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTimeSourceExample_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017ABC RID: 96956 RVA: 0x00212F88 File Offset: 0x00211188
		public new static int IsTypeOf(string type)
		{
			return vtkTimeSourceExample.vtkTimeSourceExample_IsTypeOf_16(type);
		}

		// Token: 0x06017ABD RID: 96957
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTimeSourceExample_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017ABE RID: 96958 RVA: 0x00212FA4 File Offset: 0x002111A4
		public new vtkTimeSourceExample NewInstance()
		{
			vtkTimeSourceExample result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTimeSourceExample.vtkTimeSourceExample_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTimeSourceExample)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017ABF RID: 96959
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTimeSourceExample_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017AC0 RID: 96960 RVA: 0x00213000 File Offset: 0x00211200
		public new static vtkTimeSourceExample SafeDownCast(vtkObjectBase o)
		{
			vtkTimeSourceExample vtkTimeSourceExample = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTimeSourceExample.vtkTimeSourceExample_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTimeSourceExample = (vtkTimeSourceExample)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTimeSourceExample.Register(null);
				}
			}
			return vtkTimeSourceExample;
		}

		// Token: 0x06017AC1 RID: 96961
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTimeSourceExample_SetAnalytic_20(HandleRef pThis, int _arg);

		/// <summary>
		/// When off (the default) this source produces a discrete set of values.
		/// When on, this source produces a value analytically for any queried time.
		/// </summary>
		// Token: 0x06017AC2 RID: 96962 RVA: 0x0021307F File Offset: 0x0021127F
		public virtual void SetAnalytic(int _arg)
		{
			vtkTimeSourceExample.vtkTimeSourceExample_SetAnalytic_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06017AC3 RID: 96963
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTimeSourceExample_SetGrowing_21(HandleRef pThis, int _arg);

		/// <summary>
		/// When off (the default) this produces a single cell data set.
		/// When on the number of cells (in the Y direction) grows
		/// and shrinks over time along a hat function.
		/// </summary>
		// Token: 0x06017AC4 RID: 96964 RVA: 0x0021308F File Offset: 0x0021128F
		public virtual void SetGrowing(int _arg)
		{
			vtkTimeSourceExample.vtkTimeSourceExample_SetGrowing_21(base.GetCppThis(), _arg);
		}

		// Token: 0x06017AC5 RID: 96965
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTimeSourceExample_SetXAmplitude_22(HandleRef pThis, double _arg);

		/// <summary>
		/// When 0.0 (the default) this produces a data set that is stationary.
		/// When on the data set moves in the X/Y plane over a sin wave over time,
		/// amplified by the value.
		/// </summary>
		// Token: 0x06017AC6 RID: 96966 RVA: 0x0021309F File Offset: 0x0021129F
		public virtual void SetXAmplitude(double _arg)
		{
			vtkTimeSourceExample.vtkTimeSourceExample_SetXAmplitude_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06017AC7 RID: 96967
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTimeSourceExample_SetYAmplitude_23(HandleRef pThis, double _arg);

		/// <summary>
		/// When 0.0 (the default) this produces a data set that is stationary.
		/// When on the data set moves in the X/Y plane over a sin wave over time,
		/// amplified by the value.
		/// </summary>
		// Token: 0x06017AC8 RID: 96968 RVA: 0x002130AF File Offset: 0x002112AF
		public virtual void SetYAmplitude(double _arg)
		{
			vtkTimeSourceExample.vtkTimeSourceExample_SetYAmplitude_23(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A63 RID: 6755
		public new const string MRFullTypeName = "Kitware.VTK.vtkTimeSourceExample";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A64 RID: 6756
		public new static readonly string MRClassNameKey = "class vtkTimeSourceExample";
	}
}
