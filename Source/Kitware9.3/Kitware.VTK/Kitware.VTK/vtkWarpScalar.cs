using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkWarpScalar
	/// </summary>
	/// <remarks>
	///    deform geometry with scalar data
	///
	/// vtkWarpScalar is a filter that modifies point coordinates by moving
	/// points along point normals by the scalar amount times the scale factor.
	/// Useful for creating carpet or x-y-z plots.
	///
	/// If normals are not present in data, the Normal instance variable will
	/// be used as the direction along which to warp the geometry. If normals are
	/// present but you would like to use the Normal instance variable, set the
	/// UseNormal boolean to true.
	///
	/// If XYPlane boolean is set true, then the z-value is considered to be
	/// a scalar value (still scaled by scale factor), and the displacement is
	/// along the z-axis. If scalars are also present, these are copied through
	/// and can be used to color the surface.
	///
	/// Note that the filter passes both its point data and cell data to
	/// its output, except for normals, since these are distorted by the
	/// warping.
	/// </remarks>
	// Token: 0x020008FA RID: 2298
	public class vtkWarpScalar : vtkPointSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017BB7 RID: 97207 RVA: 0x0021471D File Offset: 0x0021291D
		static vtkWarpScalar()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWarpScalar.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWarpScalar"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017BB8 RID: 97208 RVA: 0x00214745 File Offset: 0x00212945
		public vtkWarpScalar(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017BB9 RID: 97209
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWarpScalar_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information,
		/// and printing.
		/// </summary>
		// Token: 0x06017BBA RID: 97210 RVA: 0x00214754 File Offset: 0x00212954
		public new static vtkWarpScalar New()
		{
			vtkWarpScalar result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWarpScalar.vtkWarpScalar_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWarpScalar)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, obtaining type information,
		/// and printing.
		/// </summary>
		// Token: 0x06017BBB RID: 97211 RVA: 0x002147A8 File Offset: 0x002129A8
		public vtkWarpScalar() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkWarpScalar.vtkWarpScalar_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017BBC RID: 97212 RVA: 0x002147EC File Offset: 0x002129EC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017BBD RID: 97213
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWarpScalar_FillInputPortInformation_01(HandleRef pThis, int port, HandleRef info);

		/// <summary>
		/// Set/Get for a property flag that makes the filter include the input data set in the output and
		/// connects the output surface to the input surface through "side walls" effectively making a
		/// single grid enclosing a volume.
		///
		/// In order to use this functionality correctly, the input must be a two dimensional surface and
		/// cannot be 3D.
		/// </summary>
		// Token: 0x06017BBE RID: 97214 RVA: 0x002147F8 File Offset: 0x002129F8
		public virtual int FillInputPortInformation(int port, vtkInformation info)
		{
			return vtkWarpScalar.vtkWarpScalar_FillInputPortInformation_01(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x06017BBF RID: 97215
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpScalar_GenerateEnclosureOff_02(HandleRef pThis);

		/// <summary>
		/// Set/Get for a property flag that makes the filter include the input data set in the output and
		/// connects the output surface to the input surface through "side walls" effectively making a
		/// single grid enclosing a volume.
		///
		/// In order to use this functionality correctly, the input must be a two dimensional surface and
		/// cannot be 3D.
		/// </summary>
		// Token: 0x06017BC0 RID: 97216 RVA: 0x0021482D File Offset: 0x00212A2D
		public virtual void GenerateEnclosureOff()
		{
			vtkWarpScalar.vtkWarpScalar_GenerateEnclosureOff_02(base.GetCppThis());
		}

		// Token: 0x06017BC1 RID: 97217
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpScalar_GenerateEnclosureOn_03(HandleRef pThis);

		/// <summary>
		/// Set/Get for a property flag that makes the filter include the input data set in the output and
		/// connects the output surface to the input surface through "side walls" effectively making a
		/// single grid enclosing a volume.
		///
		/// In order to use this functionality correctly, the input must be a two dimensional surface and
		/// cannot be 3D.
		/// </summary>
		// Token: 0x06017BC2 RID: 97218 RVA: 0x0021483C File Offset: 0x00212A3C
		public virtual void GenerateEnclosureOn()
		{
			vtkWarpScalar.vtkWarpScalar_GenerateEnclosureOn_03(base.GetCppThis());
		}

		// Token: 0x06017BC3 RID: 97219
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkWarpScalar_GetGenerateEnclosure_04(HandleRef pThis);

		/// <summary>
		/// Set/Get for a property flag that makes the filter include the input data set in the output and
		/// connects the output surface to the input surface through "side walls" effectively making a
		/// single grid enclosing a volume.
		///
		/// In order to use this functionality correctly, the input must be a two dimensional surface and
		/// cannot be 3D.
		/// </summary>
		// Token: 0x06017BC4 RID: 97220 RVA: 0x0021484C File Offset: 0x00212A4C
		public virtual bool GetGenerateEnclosure()
		{
			return vtkWarpScalar.vtkWarpScalar_GetGenerateEnclosure_04(base.GetCppThis()) != 0;
		}

		// Token: 0x06017BC5 RID: 97221
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWarpScalar_GetNormal_05(HandleRef pThis);

		/// <summary>
		/// Normal (i.e., direction) along which to warp geometry. Only used
		/// if UseNormal boolean set to true or no normals available in data.
		/// </summary>
		// Token: 0x06017BC6 RID: 97222 RVA: 0x00214874 File Offset: 0x00212A74
		public virtual double[] GetNormal()
		{
			IntPtr intPtr = vtkWarpScalar.vtkWarpScalar_GetNormal_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06017BC7 RID: 97223
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpScalar_GetNormal_06(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Normal (i.e., direction) along which to warp geometry. Only used
		/// if UseNormal boolean set to true or no normals available in data.
		/// </summary>
		// Token: 0x06017BC8 RID: 97224 RVA: 0x002148BC File Offset: 0x00212ABC
		public virtual void GetNormal(IntPtr data)
		{
			vtkWarpScalar.vtkWarpScalar_GetNormal_06(base.GetCppThis(), data);
		}

		// Token: 0x06017BC9 RID: 97225
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWarpScalar_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information,
		/// and printing.
		/// </summary>
		// Token: 0x06017BCA RID: 97226 RVA: 0x002148CC File Offset: 0x00212ACC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkWarpScalar.vtkWarpScalar_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06017BCB RID: 97227
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWarpScalar_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information,
		/// and printing.
		/// </summary>
		// Token: 0x06017BCC RID: 97228 RVA: 0x002148EC File Offset: 0x00212AEC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkWarpScalar.vtkWarpScalar_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06017BCD RID: 97229
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWarpScalar_GetOutputPointsPrecision_09(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output points type. By default
		/// (DEFAULT_PRECISION) the output type is SINGLE_PRECISION, otherwise it is
		/// either SINGLE_PRECISION or DOUBLE_PRECISION as specified by the user.
		/// </summary>
		// Token: 0x06017BCE RID: 97230 RVA: 0x00214908 File Offset: 0x00212B08
		public virtual int GetOutputPointsPrecision()
		{
			return vtkWarpScalar.vtkWarpScalar_GetOutputPointsPrecision_09(base.GetCppThis());
		}

		// Token: 0x06017BCF RID: 97231
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkWarpScalar_GetScaleFactor_10(HandleRef pThis);

		/// <summary>
		/// Specify value to scale displacement.
		/// </summary>
		// Token: 0x06017BD0 RID: 97232 RVA: 0x00214928 File Offset: 0x00212B28
		public virtual double GetScaleFactor()
		{
			return vtkWarpScalar.vtkWarpScalar_GetScaleFactor_10(base.GetCppThis());
		}

		// Token: 0x06017BD1 RID: 97233
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWarpScalar_GetUseNormal_11(HandleRef pThis);

		/// <summary>
		/// Turn on/off use of user specified normal. If on, data normals
		/// will be ignored and instance variable Normal will be used instead.
		/// </summary>
		// Token: 0x06017BD2 RID: 97234 RVA: 0x00214948 File Offset: 0x00212B48
		public virtual int GetUseNormal()
		{
			return vtkWarpScalar.vtkWarpScalar_GetUseNormal_11(base.GetCppThis());
		}

		// Token: 0x06017BD3 RID: 97235
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWarpScalar_GetXYPlane_12(HandleRef pThis);

		/// <summary>
		/// Turn on/off flag specifying that input data is x-y plane. If x-y plane,
		/// then the z value is used to warp the surface in the z-axis direction
		/// (times the scale factor) and scalars are used to color the surface.
		/// </summary>
		// Token: 0x06017BD4 RID: 97236 RVA: 0x00214968 File Offset: 0x00212B68
		public virtual int GetXYPlane()
		{
			return vtkWarpScalar.vtkWarpScalar_GetXYPlane_12(base.GetCppThis());
		}

		// Token: 0x06017BD5 RID: 97237
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWarpScalar_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information,
		/// and printing.
		/// </summary>
		// Token: 0x06017BD6 RID: 97238 RVA: 0x00214988 File Offset: 0x00212B88
		public override int IsA(string type)
		{
			return vtkWarpScalar.vtkWarpScalar_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x06017BD7 RID: 97239
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWarpScalar_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information,
		/// and printing.
		/// </summary>
		// Token: 0x06017BD8 RID: 97240 RVA: 0x002149A8 File Offset: 0x00212BA8
		public new static int IsTypeOf(string type)
		{
			return vtkWarpScalar.vtkWarpScalar_IsTypeOf_14(type);
		}

		// Token: 0x06017BD9 RID: 97241
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWarpScalar_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information,
		/// and printing.
		/// </summary>
		// Token: 0x06017BDA RID: 97242 RVA: 0x002149C4 File Offset: 0x00212BC4
		public new vtkWarpScalar NewInstance()
		{
			vtkWarpScalar result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWarpScalar.vtkWarpScalar_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWarpScalar)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017BDB RID: 97243
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWarpScalar_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information,
		/// and printing.
		/// </summary>
		// Token: 0x06017BDC RID: 97244 RVA: 0x00214A20 File Offset: 0x00212C20
		public new static vtkWarpScalar SafeDownCast(vtkObjectBase o)
		{
			vtkWarpScalar vtkWarpScalar = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWarpScalar.vtkWarpScalar_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWarpScalar = (vtkWarpScalar)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWarpScalar.Register(null);
				}
			}
			return vtkWarpScalar;
		}

		// Token: 0x06017BDD RID: 97245
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpScalar_SetGenerateEnclosure_18(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get for a property flag that makes the filter include the input data set in the output and
		/// connects the output surface to the input surface through "side walls" effectively making a
		/// single grid enclosing a volume.
		///
		/// In order to use this functionality correctly, the input must be a two dimensional surface and
		/// cannot be 3D.
		/// </summary>
		// Token: 0x06017BDE RID: 97246 RVA: 0x00214A9F File Offset: 0x00212C9F
		public virtual void SetGenerateEnclosure(bool _arg)
		{
			vtkWarpScalar.vtkWarpScalar_SetGenerateEnclosure_18(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06017BDF RID: 97247
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpScalar_SetNormal_19(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Normal (i.e., direction) along which to warp geometry. Only used
		/// if UseNormal boolean set to true or no normals available in data.
		/// </summary>
		// Token: 0x06017BE0 RID: 97248 RVA: 0x00214AB7 File Offset: 0x00212CB7
		public virtual void SetNormal(double _arg1, double _arg2, double _arg3)
		{
			vtkWarpScalar.vtkWarpScalar_SetNormal_19(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06017BE1 RID: 97249
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpScalar_SetNormal_20(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Normal (i.e., direction) along which to warp geometry. Only used
		/// if UseNormal boolean set to true or no normals available in data.
		/// </summary>
		// Token: 0x06017BE2 RID: 97250 RVA: 0x00214AC9 File Offset: 0x00212CC9
		public virtual void SetNormal(IntPtr _arg)
		{
			vtkWarpScalar.vtkWarpScalar_SetNormal_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06017BE3 RID: 97251
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpScalar_SetOutputPointsPrecision_21(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output points type. By default
		/// (DEFAULT_PRECISION) the output type is SINGLE_PRECISION, otherwise it is
		/// either SINGLE_PRECISION or DOUBLE_PRECISION as specified by the user.
		/// </summary>
		// Token: 0x06017BE4 RID: 97252 RVA: 0x00214AD9 File Offset: 0x00212CD9
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkWarpScalar.vtkWarpScalar_SetOutputPointsPrecision_21(base.GetCppThis(), _arg);
		}

		// Token: 0x06017BE5 RID: 97253
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpScalar_SetScaleFactor_22(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify value to scale displacement.
		/// </summary>
		// Token: 0x06017BE6 RID: 97254 RVA: 0x00214AE9 File Offset: 0x00212CE9
		public virtual void SetScaleFactor(double _arg)
		{
			vtkWarpScalar.vtkWarpScalar_SetScaleFactor_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06017BE7 RID: 97255
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpScalar_SetUseNormal_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off use of user specified normal. If on, data normals
		/// will be ignored and instance variable Normal will be used instead.
		/// </summary>
		// Token: 0x06017BE8 RID: 97256 RVA: 0x00214AF9 File Offset: 0x00212CF9
		public virtual void SetUseNormal(int _arg)
		{
			vtkWarpScalar.vtkWarpScalar_SetUseNormal_23(base.GetCppThis(), _arg);
		}

		// Token: 0x06017BE9 RID: 97257
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpScalar_SetXYPlane_24(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off flag specifying that input data is x-y plane. If x-y plane,
		/// then the z value is used to warp the surface in the z-axis direction
		/// (times the scale factor) and scalars are used to color the surface.
		/// </summary>
		// Token: 0x06017BEA RID: 97258 RVA: 0x00214B09 File Offset: 0x00212D09
		public virtual void SetXYPlane(int _arg)
		{
			vtkWarpScalar.vtkWarpScalar_SetXYPlane_24(base.GetCppThis(), _arg);
		}

		// Token: 0x06017BEB RID: 97259
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpScalar_UseNormalOff_25(HandleRef pThis);

		/// <summary>
		/// Turn on/off use of user specified normal. If on, data normals
		/// will be ignored and instance variable Normal will be used instead.
		/// </summary>
		// Token: 0x06017BEC RID: 97260 RVA: 0x00214B19 File Offset: 0x00212D19
		public virtual void UseNormalOff()
		{
			vtkWarpScalar.vtkWarpScalar_UseNormalOff_25(base.GetCppThis());
		}

		// Token: 0x06017BED RID: 97261
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpScalar_UseNormalOn_26(HandleRef pThis);

		/// <summary>
		/// Turn on/off use of user specified normal. If on, data normals
		/// will be ignored and instance variable Normal will be used instead.
		/// </summary>
		// Token: 0x06017BEE RID: 97262 RVA: 0x00214B28 File Offset: 0x00212D28
		public virtual void UseNormalOn()
		{
			vtkWarpScalar.vtkWarpScalar_UseNormalOn_26(base.GetCppThis());
		}

		// Token: 0x06017BEF RID: 97263
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpScalar_XYPlaneOff_27(HandleRef pThis);

		/// <summary>
		/// Turn on/off flag specifying that input data is x-y plane. If x-y plane,
		/// then the z value is used to warp the surface in the z-axis direction
		/// (times the scale factor) and scalars are used to color the surface.
		/// </summary>
		// Token: 0x06017BF0 RID: 97264 RVA: 0x00214B37 File Offset: 0x00212D37
		public virtual void XYPlaneOff()
		{
			vtkWarpScalar.vtkWarpScalar_XYPlaneOff_27(base.GetCppThis());
		}

		// Token: 0x06017BF1 RID: 97265
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpScalar_XYPlaneOn_28(HandleRef pThis);

		/// <summary>
		/// Turn on/off flag specifying that input data is x-y plane. If x-y plane,
		/// then the z value is used to warp the surface in the z-axis direction
		/// (times the scale factor) and scalars are used to color the surface.
		/// </summary>
		// Token: 0x06017BF2 RID: 97266 RVA: 0x00214B46 File Offset: 0x00212D46
		public virtual void XYPlaneOn()
		{
			vtkWarpScalar.vtkWarpScalar_XYPlaneOn_28(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A73 RID: 6771
		public new const string MRFullTypeName = "Kitware.VTK.vtkWarpScalar";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A74 RID: 6772
		public new static readonly string MRClassNameKey = "class vtkWarpScalar";
	}
}
