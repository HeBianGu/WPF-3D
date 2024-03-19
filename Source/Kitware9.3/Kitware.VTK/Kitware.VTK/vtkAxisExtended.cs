using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAxisExtended
	/// </summary>
	/// <remarks>
	///    extended axis tick positioning
	///
	/// This implements the optimization based tick position calculating algorithm in the paper "An
	/// Extension of Wilkinson's Algorithm for Positioning Tick Labels on Axes" by Junstin Talbot, Sharon
	/// Lin and Pat Hanrahan
	///
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAxis
	/// </seealso>
	// Token: 0x02000630 RID: 1584
	public class vtkAxisExtended : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601124E RID: 70222 RVA: 0x0017E295 File Offset: 0x0017C495
		static vtkAxisExtended()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAxisExtended.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAxisExtended"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601124F RID: 70223 RVA: 0x0017E2BD File Offset: 0x0017C4BD
		public vtkAxisExtended(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011250 RID: 70224
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisExtended_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011251 RID: 70225 RVA: 0x0017E2CC File Offset: 0x0017C4CC
		public new static vtkAxisExtended New()
		{
			vtkAxisExtended result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxisExtended.vtkAxisExtended_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAxisExtended)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011252 RID: 70226 RVA: 0x0017E320 File Offset: 0x0017C520
		public vtkAxisExtended() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAxisExtended.vtkAxisExtended_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011253 RID: 70227 RVA: 0x0017E364 File Offset: 0x0017C564
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011254 RID: 70228
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisExtended_Coverage_01(double dmin, double dmax, double lmin, double lmax);

		/// <summary>
		/// This method makes the data range approximately same as the labeling
		/// range more preferable
		/// </summary>
		// Token: 0x06011255 RID: 70229 RVA: 0x0017E370 File Offset: 0x0017C570
		public static double Coverage(double dmin, double dmax, double lmin, double lmax)
		{
			return vtkAxisExtended.vtkAxisExtended_Coverage_01(dmin, dmax, lmin, lmax);
		}

		// Token: 0x06011256 RID: 70230
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisExtended_CoverageMax_02(double dmin, double dmax, double span);

		/// <summary>
		/// This gives the maximum possible value of coverage given the step size
		/// </summary>
		// Token: 0x06011257 RID: 70231 RVA: 0x0017E390 File Offset: 0x0017C590
		public static double CoverageMax(double dmin, double dmax, double span)
		{
			return vtkAxisExtended.vtkAxisExtended_CoverageMax_02(dmin, dmax, span);
		}

		// Token: 0x06011258 RID: 70232
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisExtended_Density_03(int k, double m, double dmin, double dmax, double lmin, double lmax);

		/// <summary>
		/// This method return a value to make the density of the labels close to
		/// the user given value
		/// </summary>
		// Token: 0x06011259 RID: 70233 RVA: 0x0017E3AC File Offset: 0x0017C5AC
		public static double Density(int k, double m, double dmin, double dmax, double lmin, double lmax)
		{
			return vtkAxisExtended.vtkAxisExtended_Density_03(k, m, dmin, dmax, lmin, lmax);
		}

		// Token: 0x0601125A RID: 70234
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisExtended_DensityMax_04(int k, double m);

		/// <summary>
		/// Derives the maximum values for density given k (number of ticks) and
		/// m (user given)
		/// </summary>
		// Token: 0x0601125B RID: 70235 RVA: 0x0017E3D0 File Offset: 0x0017C5D0
		public static double DensityMax(int k, double m)
		{
			return vtkAxisExtended.vtkAxisExtended_DensityMax_04(k, m);
		}

		// Token: 0x0601125C RID: 70236
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisExtended_FormatLegibilityScore_05(double n, int format);

		/// <summary>
		/// This methods return the legibility score of different formats
		/// </summary>
		// Token: 0x0601125D RID: 70237 RVA: 0x0017E3EC File Offset: 0x0017C5EC
		public static double FormatLegibilityScore(double n, int format)
		{
			return vtkAxisExtended.vtkAxisExtended_FormatLegibilityScore_05(n, format);
		}

		// Token: 0x0601125E RID: 70238
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisExtended_FormatStringLength_06(int format, double n, int precision);

		/// <summary>
		/// This method returns the string length of different format notations.
		/// </summary>
		// Token: 0x0601125F RID: 70239 RVA: 0x0017E408 File Offset: 0x0017C608
		public static int FormatStringLength(int format, double n, int precision)
		{
			return vtkAxisExtended.vtkAxisExtended_FormatStringLength_06(format, n, precision);
		}

		// Token: 0x06011260 RID: 70240
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisExtended_GenerateExtendedTickLabels_07(HandleRef pThis, double dmin, double dmax, double m, double scaling, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This method implements the algorithm given in the paper
		/// The method return the minimum tick position, maximum tick position and
		/// the tick spacing
		/// </summary>
		// Token: 0x06011261 RID: 70241 RVA: 0x0017E424 File Offset: 0x0017C624
		public vtkVector3d GenerateExtendedTickLabels(double dmin, double dmax, double m, double scaling)
		{
			vtkVector3d result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxisExtended.vtkAxisExtended_GenerateExtendedTickLabels_07(base.GetCppThis(), dmin, dmax, m, scaling, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector3d)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011262 RID: 70242
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisExtended_GetDesiredFontSize_08(HandleRef pThis);

		/// <summary>
		/// Set/Get methods for variables
		/// </summary>
		// Token: 0x06011263 RID: 70243 RVA: 0x0017E484 File Offset: 0x0017C684
		public virtual int GetDesiredFontSize()
		{
			return vtkAxisExtended.vtkAxisExtended_GetDesiredFontSize_08(base.GetCppThis());
		}

		// Token: 0x06011264 RID: 70244
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisExtended_GetFontSize_09(HandleRef pThis);

		/// <summary>
		/// Set/Get methods for variables
		/// </summary>
		// Token: 0x06011265 RID: 70245 RVA: 0x0017E4A4 File Offset: 0x0017C6A4
		public virtual int GetFontSize()
		{
			return vtkAxisExtended.vtkAxisExtended_GetFontSize_09(base.GetCppThis());
		}

		// Token: 0x06011266 RID: 70246
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAxisExtended_GetIsAxisVertical_10(HandleRef pThis);

		/// <summary>
		/// Set/Get methods for variables
		/// </summary>
		// Token: 0x06011267 RID: 70247 RVA: 0x0017E4C4 File Offset: 0x0017C6C4
		public virtual bool GetIsAxisVertical()
		{
			return vtkAxisExtended.vtkAxisExtended_GetIsAxisVertical_10(base.GetCppThis()) != 0;
		}

		// Token: 0x06011268 RID: 70248
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisExtended_GetLabelFormat_11(HandleRef pThis);

		/// <summary>
		/// Set/Get methods for variables
		/// </summary>
		// Token: 0x06011269 RID: 70249 RVA: 0x0017E4EC File Offset: 0x0017C6EC
		public virtual int GetLabelFormat()
		{
			return vtkAxisExtended.vtkAxisExtended_GetLabelFormat_11(base.GetCppThis());
		}

		// Token: 0x0601126A RID: 70250
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAxisExtended_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601126B RID: 70251 RVA: 0x0017E50C File Offset: 0x0017C70C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAxisExtended.vtkAxisExtended_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x0601126C RID: 70252
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAxisExtended_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601126D RID: 70253 RVA: 0x0017E52C File Offset: 0x0017C72C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAxisExtended.vtkAxisExtended_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x0601126E RID: 70254
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisExtended_GetOrientation_14(HandleRef pThis);

		/// <summary>
		/// Set/Get methods for variables
		/// </summary>
		// Token: 0x0601126F RID: 70255 RVA: 0x0017E548 File Offset: 0x0017C748
		public virtual int GetOrientation()
		{
			return vtkAxisExtended.vtkAxisExtended_GetOrientation_14(base.GetCppThis());
		}

		// Token: 0x06011270 RID: 70256
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisExtended_GetPrecision_15(HandleRef pThis);

		/// <summary>
		/// Set/Get methods for variables
		/// </summary>
		// Token: 0x06011271 RID: 70257 RVA: 0x0017E568 File Offset: 0x0017C768
		public virtual int GetPrecision()
		{
			return vtkAxisExtended.vtkAxisExtended_GetPrecision_15(base.GetCppThis());
		}

		// Token: 0x06011272 RID: 70258
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisExtended_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011273 RID: 70259 RVA: 0x0017E588 File Offset: 0x0017C788
		public override int IsA(string type)
		{
			return vtkAxisExtended.vtkAxisExtended_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x06011274 RID: 70260
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisExtended_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011275 RID: 70261 RVA: 0x0017E5A8 File Offset: 0x0017C7A8
		public new static int IsTypeOf(string type)
		{
			return vtkAxisExtended.vtkAxisExtended_IsTypeOf_17(type);
		}

		// Token: 0x06011276 RID: 70262
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisExtended_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011277 RID: 70263 RVA: 0x0017E5C4 File Offset: 0x0017C7C4
		public new vtkAxisExtended NewInstance()
		{
			vtkAxisExtended result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxisExtended.vtkAxisExtended_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAxisExtended)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011278 RID: 70264
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisExtended_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011279 RID: 70265 RVA: 0x0017E620 File Offset: 0x0017C820
		public new static vtkAxisExtended SafeDownCast(vtkObjectBase o)
		{
			vtkAxisExtended vtkAxisExtended = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxisExtended.vtkAxisExtended_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxisExtended = (vtkAxisExtended)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxisExtended.Register(null);
				}
			}
			return vtkAxisExtended;
		}

		// Token: 0x0601127A RID: 70266
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisExtended_SetDesiredFontSize_21(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get methods for variables
		/// </summary>
		// Token: 0x0601127B RID: 70267 RVA: 0x0017E69F File Offset: 0x0017C89F
		public virtual void SetDesiredFontSize(int _arg)
		{
			vtkAxisExtended.vtkAxisExtended_SetDesiredFontSize_21(base.GetCppThis(), _arg);
		}

		// Token: 0x0601127C RID: 70268
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisExtended_SetFontSize_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get methods for variables
		/// </summary>
		// Token: 0x0601127D RID: 70269 RVA: 0x0017E6AF File Offset: 0x0017C8AF
		public virtual void SetFontSize(int _arg)
		{
			vtkAxisExtended.vtkAxisExtended_SetFontSize_22(base.GetCppThis(), _arg);
		}

		// Token: 0x0601127E RID: 70270
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisExtended_SetIsAxisVertical_23(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get methods for variables
		/// </summary>
		// Token: 0x0601127F RID: 70271 RVA: 0x0017E6BF File Offset: 0x0017C8BF
		public virtual void SetIsAxisVertical(bool _arg)
		{
			vtkAxisExtended.vtkAxisExtended_SetIsAxisVertical_23(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011280 RID: 70272
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisExtended_SetLabelFormat_24(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get methods for variables
		/// </summary>
		// Token: 0x06011281 RID: 70273 RVA: 0x0017E6D7 File Offset: 0x0017C8D7
		public virtual void SetLabelFormat(int _arg)
		{
			vtkAxisExtended.vtkAxisExtended_SetLabelFormat_24(base.GetCppThis(), _arg);
		}

		// Token: 0x06011282 RID: 70274
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisExtended_SetOrientation_25(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get methods for variables
		/// </summary>
		// Token: 0x06011283 RID: 70275 RVA: 0x0017E6E7 File Offset: 0x0017C8E7
		public virtual void SetOrientation(int _arg)
		{
			vtkAxisExtended.vtkAxisExtended_SetOrientation_25(base.GetCppThis(), _arg);
		}

		// Token: 0x06011284 RID: 70276
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisExtended_SetPrecision_26(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get methods for variables
		/// </summary>
		// Token: 0x06011285 RID: 70277 RVA: 0x0017E6F7 File Offset: 0x0017C8F7
		public virtual void SetPrecision(int _arg)
		{
			vtkAxisExtended.vtkAxisExtended_SetPrecision_26(base.GetCppThis(), _arg);
		}

		// Token: 0x06011286 RID: 70278
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisExtended_Simplicity_27(int qIndex, int qLength, int j, double lmin, double lmax, double lstep);

		/// <summary>
		/// This method return a value to make step sizes corresponding to low q
		/// and j values more preferable
		/// </summary>
		// Token: 0x06011287 RID: 70279 RVA: 0x0017E708 File Offset: 0x0017C908
		public static double Simplicity(int qIndex, int qLength, int j, double lmin, double lmax, double lstep)
		{
			return vtkAxisExtended.vtkAxisExtended_Simplicity_27(qIndex, qLength, j, lmin, lmax, lstep);
		}

		// Token: 0x06011288 RID: 70280
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisExtended_SimplicityMax_28(int qIndex, int qLength, int j);

		/// <summary>
		/// This method returns the maximum possible value of simplicity value given
		/// q and j
		/// </summary>
		// Token: 0x06011289 RID: 70281 RVA: 0x0017E72C File Offset: 0x0017C92C
		public static double SimplicityMax(int qIndex, int qLength, int j)
		{
			return vtkAxisExtended.vtkAxisExtended_SimplicityMax_28(qIndex, qLength, j);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040013D0 RID: 5072
		public new const string MRFullTypeName = "Kitware.VTK.vtkAxisExtended";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040013D1 RID: 5073
		public new static readonly string MRClassNameKey = "class vtkAxisExtended";
	}
}
