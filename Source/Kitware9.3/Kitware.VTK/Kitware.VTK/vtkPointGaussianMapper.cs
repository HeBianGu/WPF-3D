using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPointGaussianMapper
	/// </summary>
	/// <remarks>
	///    draw PointGaussians using imposters
	///
	///
	/// A mapper that uses imposters to draw gaussian splats or other shapes if
	/// custom shader code is set. Supports transparency and picking as well. It
	/// draws all the points and does not require cell arrays. If cell arrays are
	/// provided it will only draw the points used by the Verts cell array. The shape
	/// of the imposter is a triangle.
	/// </remarks>
	// Token: 0x020005BE RID: 1470
	public class vtkPointGaussianMapper : vtkPolyDataMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601013B RID: 65851 RVA: 0x001663F3 File Offset: 0x001645F3
		static vtkPointGaussianMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointGaussianMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointGaussianMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601013C RID: 65852 RVA: 0x0016641B File Offset: 0x0016461B
		public vtkPointGaussianMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601013D RID: 65853
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointGaussianMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601013E RID: 65854 RVA: 0x0016642C File Offset: 0x0016462C
		public new static vtkPointGaussianMapper New()
		{
			vtkPointGaussianMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointGaussianMapper.vtkPointGaussianMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointGaussianMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601013F RID: 65855 RVA: 0x00166480 File Offset: 0x00164680
		public vtkPointGaussianMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPointGaussianMapper.vtkPointGaussianMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010140 RID: 65856 RVA: 0x001664C4 File Offset: 0x001646C4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010141 RID: 65857
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointGaussianMapper_EmissiveOff_01(HandleRef pThis);

		/// <summary>
		/// Treat the points/splats as emissive light sources. The default is true.
		/// </summary>
		// Token: 0x06010142 RID: 65858 RVA: 0x001664CF File Offset: 0x001646CF
		public virtual void EmissiveOff()
		{
			vtkPointGaussianMapper.vtkPointGaussianMapper_EmissiveOff_01(base.GetCppThis());
		}

		// Token: 0x06010143 RID: 65859
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointGaussianMapper_EmissiveOn_02(HandleRef pThis);

		/// <summary>
		/// Treat the points/splats as emissive light sources. The default is true.
		/// </summary>
		// Token: 0x06010144 RID: 65860 RVA: 0x001664DE File Offset: 0x001646DE
		public virtual void EmissiveOn()
		{
			vtkPointGaussianMapper.vtkPointGaussianMapper_EmissiveOn_02(base.GetCppThis());
		}

		// Token: 0x06010145 RID: 65861
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointGaussianMapper_GetEmissive_03(HandleRef pThis);

		/// <summary>
		/// Treat the points/splats as emissive light sources. The default is true.
		/// </summary>
		// Token: 0x06010146 RID: 65862 RVA: 0x001664F0 File Offset: 0x001646F0
		public virtual int GetEmissive()
		{
			return vtkPointGaussianMapper.vtkPointGaussianMapper_GetEmissive_03(base.GetCppThis());
		}

		// Token: 0x06010147 RID: 65863
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointGaussianMapper_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010148 RID: 65864 RVA: 0x00166510 File Offset: 0x00164710
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPointGaussianMapper.vtkPointGaussianMapper_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06010149 RID: 65865
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointGaussianMapper_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601014A RID: 65866 RVA: 0x00166530 File Offset: 0x00164730
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPointGaussianMapper.vtkPointGaussianMapper_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601014B RID: 65867
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointGaussianMapper_GetOpacityArray_06(HandleRef pThis);

		/// <summary>
		/// Method to set the optional opacity array.  If specified this
		/// array will be used to generate the opacity values.
		/// </summary>
		// Token: 0x0601014C RID: 65868 RVA: 0x0016654C File Offset: 0x0016474C
		public virtual string GetOpacityArray()
		{
			string s = Marshal.PtrToStringAnsi(vtkPointGaussianMapper.vtkPointGaussianMapper_GetOpacityArray_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601014D RID: 65869
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointGaussianMapper_GetOpacityArrayComponent_07(HandleRef pThis);

		/// <summary>
		/// Convenience method to set the component of the array to opacify with.
		/// </summary>
		// Token: 0x0601014E RID: 65870 RVA: 0x00166588 File Offset: 0x00164788
		public virtual int GetOpacityArrayComponent()
		{
			return vtkPointGaussianMapper.vtkPointGaussianMapper_GetOpacityArrayComponent_07(base.GetCppThis());
		}

		// Token: 0x0601014F RID: 65871
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointGaussianMapper_GetOpacityTableSize_08(HandleRef pThis);

		/// <summary>
		/// The size of the table used in computing opacities, used when
		/// converting a vtkPiecewiseFunction to a table
		/// </summary>
		// Token: 0x06010150 RID: 65872 RVA: 0x001665A8 File Offset: 0x001647A8
		public virtual int GetOpacityTableSize()
		{
			return vtkPointGaussianMapper.vtkPointGaussianMapper_GetOpacityTableSize_08(base.GetCppThis());
		}

		// Token: 0x06010151 RID: 65873
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointGaussianMapper_GetScalarOpacityFunction_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the optional opacity transfer function. This is only
		/// used when an OpacityArray is also specified.
		/// </summary>
		// Token: 0x06010152 RID: 65874 RVA: 0x001665C8 File Offset: 0x001647C8
		public virtual vtkPiecewiseFunction GetScalarOpacityFunction()
		{
			vtkPiecewiseFunction vtkPiecewiseFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointGaussianMapper.vtkPointGaussianMapper_GetScalarOpacityFunction_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPiecewiseFunction = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPiecewiseFunction.Register(null);
				}
			}
			return vtkPiecewiseFunction;
		}

		// Token: 0x06010153 RID: 65875
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointGaussianMapper_GetScaleArray_10(HandleRef pThis);

		/// <summary>
		/// Convenience method to set the array to scale with.
		/// </summary>
		// Token: 0x06010154 RID: 65876 RVA: 0x00166638 File Offset: 0x00164838
		public virtual string GetScaleArray()
		{
			string s = Marshal.PtrToStringAnsi(vtkPointGaussianMapper.vtkPointGaussianMapper_GetScaleArray_10(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06010155 RID: 65877
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointGaussianMapper_GetScaleArrayComponent_11(HandleRef pThis);

		/// <summary>
		/// Convenience method to set the component of the array to scale with.
		/// </summary>
		// Token: 0x06010156 RID: 65878 RVA: 0x00166674 File Offset: 0x00164874
		public virtual int GetScaleArrayComponent()
		{
			return vtkPointGaussianMapper.vtkPointGaussianMapper_GetScaleArrayComponent_11(base.GetCppThis());
		}

		// Token: 0x06010157 RID: 65879
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointGaussianMapper_GetScaleFactor_12(HandleRef pThis);

		/// <summary>
		/// Set the default scale factor of the point gaussians.  This
		/// defaults to 1.0. All radius computations will be scaled by the factor
		/// including the ScaleArray. If a vtkPiecewideFunction is used the
		/// scaling happens prior to the function lookup.
		/// A scale factor of 0.0 indicates that the splats should be rendered
		/// as simple points.
		/// </summary>
		// Token: 0x06010158 RID: 65880 RVA: 0x00166694 File Offset: 0x00164894
		public virtual double GetScaleFactor()
		{
			return vtkPointGaussianMapper.vtkPointGaussianMapper_GetScaleFactor_12(base.GetCppThis());
		}

		// Token: 0x06010159 RID: 65881
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointGaussianMapper_GetScaleFunction_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the optional scale transfer function. This is only
		/// used when a ScaleArray is also specified.
		/// </summary>
		// Token: 0x0601015A RID: 65882 RVA: 0x001666B4 File Offset: 0x001648B4
		public virtual vtkPiecewiseFunction GetScaleFunction()
		{
			vtkPiecewiseFunction vtkPiecewiseFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointGaussianMapper.vtkPointGaussianMapper_GetScaleFunction_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPiecewiseFunction = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPiecewiseFunction.Register(null);
				}
			}
			return vtkPiecewiseFunction;
		}

		// Token: 0x0601015B RID: 65883
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointGaussianMapper_GetScaleTableSize_14(HandleRef pThis);

		/// <summary>
		/// The size of the table used in computing scale, used when
		/// converting a vtkPiecewiseFunction to a table
		/// </summary>
		// Token: 0x0601015C RID: 65884 RVA: 0x00166724 File Offset: 0x00164924
		public virtual int GetScaleTableSize()
		{
			return vtkPointGaussianMapper.vtkPointGaussianMapper_GetScaleTableSize_14(base.GetCppThis());
		}

		// Token: 0x0601015D RID: 65885
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointGaussianMapper_GetSplatShaderCode_15(HandleRef pThis);

		/// <summary>
		/// Method to override the fragment shader code for the splat.  You can
		/// set this to draw other shapes. For the OPenGL2 backend some of
		/// the variables you can use and/or modify include,
		/// opacity - 0.0 to 1.0
		/// diffuseColor - vec3
		/// ambientColor - vec3
		/// offsetVCVSOutput - vec2 offset in view coordinates from the splat center
		/// </summary>
		// Token: 0x0601015E RID: 65886 RVA: 0x00166744 File Offset: 0x00164944
		public virtual string GetSplatShaderCode()
		{
			string s = Marshal.PtrToStringAnsi(vtkPointGaussianMapper.vtkPointGaussianMapper_GetSplatShaderCode_15(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601015F RID: 65887
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPointGaussianMapper_GetSupportsSelection_16(HandleRef pThis);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// Used by vtkHardwareSelector to determine if the prop supports hardware
		/// selection.
		/// </summary>
		// Token: 0x06010160 RID: 65888 RVA: 0x00166780 File Offset: 0x00164980
		public override bool GetSupportsSelection()
		{
			return vtkPointGaussianMapper.vtkPointGaussianMapper_GetSupportsSelection_16(base.GetCppThis()) != 0;
		}

		// Token: 0x06010161 RID: 65889
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkPointGaussianMapper_GetTriangleScale_17(HandleRef pThis);

		/// <summary>
		/// When drawing triangles as opposed too point mode
		/// (triangles are for splats shaders that are bigger than a pixel)
		/// this controls how large the triangle will be. By default it
		/// is large enough to contain a cicle of radius 3.0*scale which works
		/// well for gaussian splats as after 3.0 standard deviations the
		/// opacity is near zero. For custom shader codes a different
		/// value can be used. Generally you should use the lowest value you can
		/// as it will result in fewer fragments. For example if your custom
		/// shader only draws a disc of radius 1.0*scale, then set this to 1.0
		/// to avoid sending many fragments to the shader that will just get
		/// discarded.
		/// </summary>
		// Token: 0x06010162 RID: 65890 RVA: 0x001667A8 File Offset: 0x001649A8
		public virtual float GetTriangleScale()
		{
			return vtkPointGaussianMapper.vtkPointGaussianMapper_GetTriangleScale_17(base.GetCppThis());
		}

		// Token: 0x06010163 RID: 65891
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointGaussianMapper_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010164 RID: 65892 RVA: 0x001667C8 File Offset: 0x001649C8
		public override int IsA(string type)
		{
			return vtkPointGaussianMapper.vtkPointGaussianMapper_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x06010165 RID: 65893
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointGaussianMapper_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010166 RID: 65894 RVA: 0x001667E8 File Offset: 0x001649E8
		public new static int IsTypeOf(string type)
		{
			return vtkPointGaussianMapper.vtkPointGaussianMapper_IsTypeOf_19(type);
		}

		// Token: 0x06010167 RID: 65895
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointGaussianMapper_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010168 RID: 65896 RVA: 0x00166804 File Offset: 0x00164A04
		public new vtkPointGaussianMapper NewInstance()
		{
			vtkPointGaussianMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointGaussianMapper.vtkPointGaussianMapper_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointGaussianMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010169 RID: 65897
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointGaussianMapper_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601016A RID: 65898 RVA: 0x00166860 File Offset: 0x00164A60
		public new static vtkPointGaussianMapper SafeDownCast(vtkObjectBase o)
		{
			vtkPointGaussianMapper vtkPointGaussianMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointGaussianMapper.vtkPointGaussianMapper_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointGaussianMapper = (vtkPointGaussianMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointGaussianMapper.Register(null);
				}
			}
			return vtkPointGaussianMapper;
		}

		// Token: 0x0601016B RID: 65899
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointGaussianMapper_SetEmissive_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Treat the points/splats as emissive light sources. The default is true.
		/// </summary>
		// Token: 0x0601016C RID: 65900 RVA: 0x001668DF File Offset: 0x00164ADF
		public virtual void SetEmissive(int _arg)
		{
			vtkPointGaussianMapper.vtkPointGaussianMapper_SetEmissive_23(base.GetCppThis(), _arg);
		}

		// Token: 0x0601016D RID: 65901
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointGaussianMapper_SetOpacityArray_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Method to set the optional opacity array.  If specified this
		/// array will be used to generate the opacity values.
		/// </summary>
		// Token: 0x0601016E RID: 65902 RVA: 0x001668EF File Offset: 0x00164AEF
		public virtual void SetOpacityArray(string _arg)
		{
			vtkPointGaussianMapper.vtkPointGaussianMapper_SetOpacityArray_24(base.GetCppThis(), _arg);
		}

		// Token: 0x0601016F RID: 65903
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointGaussianMapper_SetOpacityArrayComponent_25(HandleRef pThis, int _arg);

		/// <summary>
		/// Convenience method to set the component of the array to opacify with.
		/// </summary>
		// Token: 0x06010170 RID: 65904 RVA: 0x001668FF File Offset: 0x00164AFF
		public virtual void SetOpacityArrayComponent(int _arg)
		{
			vtkPointGaussianMapper.vtkPointGaussianMapper_SetOpacityArrayComponent_25(base.GetCppThis(), _arg);
		}

		// Token: 0x06010171 RID: 65905
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointGaussianMapper_SetOpacityTableSize_26(HandleRef pThis, int _arg);

		/// <summary>
		/// The size of the table used in computing opacities, used when
		/// converting a vtkPiecewiseFunction to a table
		/// </summary>
		// Token: 0x06010172 RID: 65906 RVA: 0x0016690F File Offset: 0x00164B0F
		public virtual void SetOpacityTableSize(int _arg)
		{
			vtkPointGaussianMapper.vtkPointGaussianMapper_SetOpacityTableSize_26(base.GetCppThis(), _arg);
		}

		// Token: 0x06010173 RID: 65907
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointGaussianMapper_SetScalarOpacityFunction_27(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the optional opacity transfer function. This is only
		/// used when an OpacityArray is also specified.
		/// </summary>
		// Token: 0x06010174 RID: 65908 RVA: 0x00166920 File Offset: 0x00164B20
		public void SetScalarOpacityFunction(vtkPiecewiseFunction arg0)
		{
			vtkPointGaussianMapper.vtkPointGaussianMapper_SetScalarOpacityFunction_27(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06010175 RID: 65909
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointGaussianMapper_SetScaleArray_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Convenience method to set the array to scale with.
		/// </summary>
		// Token: 0x06010176 RID: 65910 RVA: 0x0016694F File Offset: 0x00164B4F
		public virtual void SetScaleArray(string _arg)
		{
			vtkPointGaussianMapper.vtkPointGaussianMapper_SetScaleArray_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06010177 RID: 65911
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointGaussianMapper_SetScaleArrayComponent_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Convenience method to set the component of the array to scale with.
		/// </summary>
		// Token: 0x06010178 RID: 65912 RVA: 0x0016695F File Offset: 0x00164B5F
		public virtual void SetScaleArrayComponent(int _arg)
		{
			vtkPointGaussianMapper.vtkPointGaussianMapper_SetScaleArrayComponent_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06010179 RID: 65913
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointGaussianMapper_SetScaleFactor_30(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the default scale factor of the point gaussians.  This
		/// defaults to 1.0. All radius computations will be scaled by the factor
		/// including the ScaleArray. If a vtkPiecewideFunction is used the
		/// scaling happens prior to the function lookup.
		/// A scale factor of 0.0 indicates that the splats should be rendered
		/// as simple points.
		/// </summary>
		// Token: 0x0601017A RID: 65914 RVA: 0x0016696F File Offset: 0x00164B6F
		public virtual void SetScaleFactor(double _arg)
		{
			vtkPointGaussianMapper.vtkPointGaussianMapper_SetScaleFactor_30(base.GetCppThis(), _arg);
		}

		// Token: 0x0601017B RID: 65915
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointGaussianMapper_SetScaleFunction_31(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the optional scale transfer function. This is only
		/// used when a ScaleArray is also specified.
		/// </summary>
		// Token: 0x0601017C RID: 65916 RVA: 0x00166980 File Offset: 0x00164B80
		public void SetScaleFunction(vtkPiecewiseFunction arg0)
		{
			vtkPointGaussianMapper.vtkPointGaussianMapper_SetScaleFunction_31(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601017D RID: 65917
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointGaussianMapper_SetScaleTableSize_32(HandleRef pThis, int _arg);

		/// <summary>
		/// The size of the table used in computing scale, used when
		/// converting a vtkPiecewiseFunction to a table
		/// </summary>
		// Token: 0x0601017E RID: 65918 RVA: 0x001669AF File Offset: 0x00164BAF
		public virtual void SetScaleTableSize(int _arg)
		{
			vtkPointGaussianMapper.vtkPointGaussianMapper_SetScaleTableSize_32(base.GetCppThis(), _arg);
		}

		// Token: 0x0601017F RID: 65919
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointGaussianMapper_SetSplatShaderCode_33(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Method to override the fragment shader code for the splat.  You can
		/// set this to draw other shapes. For the OPenGL2 backend some of
		/// the variables you can use and/or modify include,
		/// opacity - 0.0 to 1.0
		/// diffuseColor - vec3
		/// ambientColor - vec3
		/// offsetVCVSOutput - vec2 offset in view coordinates from the splat center
		/// </summary>
		// Token: 0x06010180 RID: 65920 RVA: 0x001669BF File Offset: 0x00164BBF
		public virtual void SetSplatShaderCode(string _arg)
		{
			vtkPointGaussianMapper.vtkPointGaussianMapper_SetSplatShaderCode_33(base.GetCppThis(), _arg);
		}

		// Token: 0x06010181 RID: 65921
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointGaussianMapper_SetTriangleScale_34(HandleRef pThis, float _arg);

		/// <summary>
		/// When drawing triangles as opposed too point mode
		/// (triangles are for splats shaders that are bigger than a pixel)
		/// this controls how large the triangle will be. By default it
		/// is large enough to contain a cicle of radius 3.0*scale which works
		/// well for gaussian splats as after 3.0 standard deviations the
		/// opacity is near zero. For custom shader codes a different
		/// value can be used. Generally you should use the lowest value you can
		/// as it will result in fewer fragments. For example if your custom
		/// shader only draws a disc of radius 1.0*scale, then set this to 1.0
		/// to avoid sending many fragments to the shader that will just get
		/// discarded.
		/// </summary>
		// Token: 0x06010182 RID: 65922 RVA: 0x001669CF File Offset: 0x00164BCF
		public virtual void SetTriangleScale(float _arg)
		{
			vtkPointGaussianMapper.vtkPointGaussianMapper_SetTriangleScale_34(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012BE RID: 4798
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointGaussianMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012BF RID: 4799
		public new static readonly string MRClassNameKey = "class vtkPointGaussianMapper";
	}
}
