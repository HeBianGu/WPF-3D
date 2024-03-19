using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTextSource
	/// </summary>
	/// <remarks>
	///    create polygonal text
	///
	/// vtkTextSource converts a text string into polygons.  This way you can
	/// insert text into your renderings. It uses the 9x15 font from X Windows.
	/// You can specify if you want the background to be drawn or not. The
	/// characters are formed by scan converting the raster font into
	/// quadrilaterals. Colors are assigned to the letters using scalar data.
	/// To set the color of the characters with the source's actor property, set
	/// BackingOff on the text source and ScalarVisibilityOff on the associated
	/// vtkPolyDataMapper. Then, the color can be set using the associated actor's
	/// property.
	///
	/// vtkVectorText generates higher quality polygonal representations of
	/// characters.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkVectorText
	/// </seealso>
	// Token: 0x02000846 RID: 2118
	public class vtkTextSource : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06015F44 RID: 89924 RVA: 0x001EED8F File Offset: 0x001ECF8F
		static vtkTextSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTextSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015F45 RID: 89925 RVA: 0x001EEDB7 File Offset: 0x001ECFB7
		public vtkTextSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06015F46 RID: 89926
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with no string set and backing enabled.
		/// </summary>
		// Token: 0x06015F47 RID: 89927 RVA: 0x001EEDC8 File Offset: 0x001ECFC8
		public new static vtkTextSource New()
		{
			vtkTextSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextSource.vtkTextSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with no string set and backing enabled.
		/// </summary>
		// Token: 0x06015F48 RID: 89928 RVA: 0x001EEE1C File Offset: 0x001ED01C
		public vtkTextSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTextSource.vtkTextSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015F49 RID: 89929 RVA: 0x001EEE60 File Offset: 0x001ED060
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015F4A RID: 89930
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextSource_BackingOff_01(HandleRef pThis);

		/// <summary>
		/// Controls whether or not a background is drawn with the text.
		/// </summary>
		// Token: 0x06015F4B RID: 89931 RVA: 0x001EEE6B File Offset: 0x001ED06B
		public virtual void BackingOff()
		{
			vtkTextSource.vtkTextSource_BackingOff_01(base.GetCppThis());
		}

		// Token: 0x06015F4C RID: 89932
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextSource_BackingOn_02(HandleRef pThis);

		/// <summary>
		/// Controls whether or not a background is drawn with the text.
		/// </summary>
		// Token: 0x06015F4D RID: 89933 RVA: 0x001EEE7A File Offset: 0x001ED07A
		public virtual void BackingOn()
		{
			vtkTextSource.vtkTextSource_BackingOn_02(base.GetCppThis());
		}

		// Token: 0x06015F4E RID: 89934
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextSource_GetBackgroundColor_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the background color. Default is black (0,0,0). Alpha is always 1.
		/// </summary>
		// Token: 0x06015F4F RID: 89935 RVA: 0x001EEE8C File Offset: 0x001ED08C
		public virtual double[] GetBackgroundColor()
		{
			IntPtr intPtr = vtkTextSource.vtkTextSource_GetBackgroundColor_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06015F50 RID: 89936
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextSource_GetBackgroundColor_04(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the background color. Default is black (0,0,0). Alpha is always 1.
		/// </summary>
		// Token: 0x06015F51 RID: 89937 RVA: 0x001EEED4 File Offset: 0x001ED0D4
		public virtual void GetBackgroundColor(IntPtr data)
		{
			vtkTextSource.vtkTextSource_GetBackgroundColor_04(base.GetCppThis(), data);
		}

		// Token: 0x06015F52 RID: 89938
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextSource_GetBacking_05(HandleRef pThis);

		/// <summary>
		/// Controls whether or not a background is drawn with the text.
		/// </summary>
		// Token: 0x06015F53 RID: 89939 RVA: 0x001EEEE4 File Offset: 0x001ED0E4
		public virtual int GetBacking()
		{
			return vtkTextSource.vtkTextSource_GetBacking_05(base.GetCppThis());
		}

		// Token: 0x06015F54 RID: 89940
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextSource_GetForegroundColor_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the foreground color. Default is white (1,1,1). ALpha is always 1.
		/// </summary>
		// Token: 0x06015F55 RID: 89941 RVA: 0x001EEF04 File Offset: 0x001ED104
		public virtual double[] GetForegroundColor()
		{
			IntPtr intPtr = vtkTextSource.vtkTextSource_GetForegroundColor_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06015F56 RID: 89942
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextSource_GetForegroundColor_07(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the foreground color. Default is white (1,1,1). ALpha is always 1.
		/// </summary>
		// Token: 0x06015F57 RID: 89943 RVA: 0x001EEF4C File Offset: 0x001ED14C
		public virtual void GetForegroundColor(IntPtr data)
		{
			vtkTextSource.vtkTextSource_GetForegroundColor_07(base.GetCppThis(), data);
		}

		// Token: 0x06015F58 RID: 89944
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTextSource_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015F59 RID: 89945 RVA: 0x001EEF5C File Offset: 0x001ED15C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTextSource.vtkTextSource_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x06015F5A RID: 89946
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTextSource_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015F5B RID: 89947 RVA: 0x001EEF7C File Offset: 0x001ED17C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTextSource.vtkTextSource_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x06015F5C RID: 89948
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextSource_GetOutputPointsPrecision_10(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x06015F5D RID: 89949 RVA: 0x001EEF98 File Offset: 0x001ED198
		public virtual int GetOutputPointsPrecision()
		{
			return vtkTextSource.vtkTextSource_GetOutputPointsPrecision_10(base.GetCppThis());
		}

		// Token: 0x06015F5E RID: 89950
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextSource_GetText_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the text to be drawn.
		/// </summary>
		// Token: 0x06015F5F RID: 89951 RVA: 0x001EEFB8 File Offset: 0x001ED1B8
		public virtual string GetText()
		{
			string s = Marshal.PtrToStringAnsi(vtkTextSource.vtkTextSource_GetText_11(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06015F60 RID: 89952
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextSource_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015F61 RID: 89953 RVA: 0x001EEFF4 File Offset: 0x001ED1F4
		public override int IsA(string type)
		{
			return vtkTextSource.vtkTextSource_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x06015F62 RID: 89954
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextSource_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015F63 RID: 89955 RVA: 0x001EF014 File Offset: 0x001ED214
		public new static int IsTypeOf(string type)
		{
			return vtkTextSource.vtkTextSource_IsTypeOf_13(type);
		}

		// Token: 0x06015F64 RID: 89956
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextSource_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015F65 RID: 89957 RVA: 0x001EF030 File Offset: 0x001ED230
		public new vtkTextSource NewInstance()
		{
			vtkTextSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextSource.vtkTextSource_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06015F66 RID: 89958
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextSource_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015F67 RID: 89959 RVA: 0x001EF08C File Offset: 0x001ED28C
		public new static vtkTextSource SafeDownCast(vtkObjectBase o)
		{
			vtkTextSource vtkTextSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextSource.vtkTextSource_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextSource = (vtkTextSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextSource.Register(null);
				}
			}
			return vtkTextSource;
		}

		// Token: 0x06015F68 RID: 89960
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextSource_SetBackgroundColor_17(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the background color. Default is black (0,0,0). Alpha is always 1.
		/// </summary>
		// Token: 0x06015F69 RID: 89961 RVA: 0x001EF10B File Offset: 0x001ED30B
		public virtual void SetBackgroundColor(double _arg1, double _arg2, double _arg3)
		{
			vtkTextSource.vtkTextSource_SetBackgroundColor_17(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06015F6A RID: 89962
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextSource_SetBackgroundColor_18(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the background color. Default is black (0,0,0). Alpha is always 1.
		/// </summary>
		// Token: 0x06015F6B RID: 89963 RVA: 0x001EF11D File Offset: 0x001ED31D
		public virtual void SetBackgroundColor(IntPtr _arg)
		{
			vtkTextSource.vtkTextSource_SetBackgroundColor_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06015F6C RID: 89964
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextSource_SetBacking_19(HandleRef pThis, int _arg);

		/// <summary>
		/// Controls whether or not a background is drawn with the text.
		/// </summary>
		// Token: 0x06015F6D RID: 89965 RVA: 0x001EF12D File Offset: 0x001ED32D
		public virtual void SetBacking(int _arg)
		{
			vtkTextSource.vtkTextSource_SetBacking_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06015F6E RID: 89966
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextSource_SetForegroundColor_20(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the foreground color. Default is white (1,1,1). ALpha is always 1.
		/// </summary>
		// Token: 0x06015F6F RID: 89967 RVA: 0x001EF13D File Offset: 0x001ED33D
		public virtual void SetForegroundColor(double _arg1, double _arg2, double _arg3)
		{
			vtkTextSource.vtkTextSource_SetForegroundColor_20(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06015F70 RID: 89968
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextSource_SetForegroundColor_21(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the foreground color. Default is white (1,1,1). ALpha is always 1.
		/// </summary>
		// Token: 0x06015F71 RID: 89969 RVA: 0x001EF14F File Offset: 0x001ED34F
		public virtual void SetForegroundColor(IntPtr _arg)
		{
			vtkTextSource.vtkTextSource_SetForegroundColor_21(base.GetCppThis(), _arg);
		}

		// Token: 0x06015F72 RID: 89970
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextSource_SetOutputPointsPrecision_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x06015F73 RID: 89971 RVA: 0x001EF15F File Offset: 0x001ED35F
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkTextSource.vtkTextSource_SetOutputPointsPrecision_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06015F74 RID: 89972
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextSource_SetText_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the text to be drawn.
		/// </summary>
		// Token: 0x06015F75 RID: 89973 RVA: 0x001EF16F File Offset: 0x001ED36F
		public virtual void SetText(string _arg)
		{
			vtkTextSource.vtkTextSource_SetText_23(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018E0 RID: 6368
		public new const string MRFullTypeName = "Kitware.VTK.vtkTextSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018E1 RID: 6369
		public new static readonly string MRClassNameKey = "class vtkTextSource";
	}
}
