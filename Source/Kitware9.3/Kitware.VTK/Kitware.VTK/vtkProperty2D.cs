using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkProperty2D
	/// </summary>
	/// <remarks>
	///    represent surface properties of a 2D image
	///
	/// vtkProperty2D contains properties used to render two dimensional images
	/// and annotations.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkActor2D
	/// </seealso>
	// Token: 0x020007F9 RID: 2041
	public class vtkProperty2D : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014F6A RID: 85866 RVA: 0x001DAA6F File Offset: 0x001D8C6F
		static vtkProperty2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProperty2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProperty2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014F6B RID: 85867 RVA: 0x001DAA97 File Offset: 0x001D8C97
		public vtkProperty2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014F6C RID: 85868
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProperty2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a vtkProperty2D with the following default values:
		/// Opacity 1, Color (1,1,1)
		/// </summary>
		// Token: 0x06014F6D RID: 85869 RVA: 0x001DAAA8 File Offset: 0x001D8CA8
		public new static vtkProperty2D New()
		{
			vtkProperty2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProperty2D.vtkProperty2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a vtkProperty2D with the following default values:
		/// Opacity 1, Color (1,1,1)
		/// </summary>
		// Token: 0x06014F6E RID: 85870 RVA: 0x001DAAFC File Offset: 0x001D8CFC
		public vtkProperty2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkProperty2D.vtkProperty2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014F6F RID: 85871 RVA: 0x001DAB40 File Offset: 0x001D8D40
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014F70 RID: 85872
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty2D_DeepCopy_01(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Assign one property to another.
		/// </summary>
		// Token: 0x06014F71 RID: 85873 RVA: 0x001DAB4C File Offset: 0x001D8D4C
		public void DeepCopy(vtkProperty2D p)
		{
			vtkProperty2D.vtkProperty2D_DeepCopy_01(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x06014F72 RID: 85874
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProperty2D_GetColor_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the RGB color of this property.
		/// </summary>
		// Token: 0x06014F73 RID: 85875 RVA: 0x001DAB7C File Offset: 0x001D8D7C
		public virtual double[] GetColor()
		{
			IntPtr intPtr = vtkProperty2D.vtkProperty2D_GetColor_02(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06014F74 RID: 85876
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty2D_GetColor_03(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the RGB color of this property.
		/// </summary>
		// Token: 0x06014F75 RID: 85877 RVA: 0x001DABC4 File Offset: 0x001D8DC4
		public virtual void GetColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkProperty2D.vtkProperty2D_GetColor_03(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06014F76 RID: 85878
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty2D_GetColor_04(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the RGB color of this property.
		/// </summary>
		// Token: 0x06014F77 RID: 85879 RVA: 0x001DABD6 File Offset: 0x001D8DD6
		public virtual void GetColor(IntPtr _arg)
		{
			vtkProperty2D.vtkProperty2D_GetColor_04(base.GetCppThis(), _arg);
		}

		// Token: 0x06014F78 RID: 85880
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProperty2D_GetDisplayLocation_05(HandleRef pThis);

		/// <summary>
		/// The DisplayLocation is either background or foreground.
		/// If it is background, then this 2D actor will be drawn
		/// behind all 3D props or foreground 2D actors. If it is
		/// foreground, then this 2D actor will be drawn in front of
		/// all 3D props and background 2D actors. Within 2D actors
		/// of the same DisplayLocation type, order is determined by
		/// the order in which the 2D actors were added to the viewport.
		/// </summary>
		// Token: 0x06014F79 RID: 85881 RVA: 0x001DABE8 File Offset: 0x001D8DE8
		public virtual int GetDisplayLocation()
		{
			return vtkProperty2D.vtkProperty2D_GetDisplayLocation_05(base.GetCppThis());
		}

		// Token: 0x06014F7A RID: 85882
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProperty2D_GetDisplayLocationMaxValue_06(HandleRef pThis);

		/// <summary>
		/// The DisplayLocation is either background or foreground.
		/// If it is background, then this 2D actor will be drawn
		/// behind all 3D props or foreground 2D actors. If it is
		/// foreground, then this 2D actor will be drawn in front of
		/// all 3D props and background 2D actors. Within 2D actors
		/// of the same DisplayLocation type, order is determined by
		/// the order in which the 2D actors were added to the viewport.
		/// </summary>
		// Token: 0x06014F7B RID: 85883 RVA: 0x001DAC08 File Offset: 0x001D8E08
		public virtual int GetDisplayLocationMaxValue()
		{
			return vtkProperty2D.vtkProperty2D_GetDisplayLocationMaxValue_06(base.GetCppThis());
		}

		// Token: 0x06014F7C RID: 85884
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProperty2D_GetDisplayLocationMinValue_07(HandleRef pThis);

		/// <summary>
		/// The DisplayLocation is either background or foreground.
		/// If it is background, then this 2D actor will be drawn
		/// behind all 3D props or foreground 2D actors. If it is
		/// foreground, then this 2D actor will be drawn in front of
		/// all 3D props and background 2D actors. Within 2D actors
		/// of the same DisplayLocation type, order is determined by
		/// the order in which the 2D actors were added to the viewport.
		/// </summary>
		// Token: 0x06014F7D RID: 85885 RVA: 0x001DAC28 File Offset: 0x001D8E28
		public virtual int GetDisplayLocationMinValue()
		{
			return vtkProperty2D.vtkProperty2D_GetDisplayLocationMinValue_07(base.GetCppThis());
		}

		// Token: 0x06014F7E RID: 85886
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProperty2D_GetLineStipplePattern_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the stippling pattern of a Line, as a 16-bit binary pattern
		/// (1 = pixel on, 0 = pixel off).
		/// This is only implemented for OpenGL, not OpenGL2. The default is 0xFFFF.
		/// </summary>
		// Token: 0x06014F7F RID: 85887 RVA: 0x001DAC48 File Offset: 0x001D8E48
		public virtual int GetLineStipplePattern()
		{
			return vtkProperty2D.vtkProperty2D_GetLineStipplePattern_08(base.GetCppThis());
		}

		// Token: 0x06014F80 RID: 85888
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProperty2D_GetLineStippleRepeatFactor_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the stippling repeat factor of a Line, which specifies how
		/// many times each bit in the pattern is to be repeated.
		/// This is only implemented for OpenGL, not OpenGL2. The default is 1.
		/// </summary>
		// Token: 0x06014F81 RID: 85889 RVA: 0x001DAC68 File Offset: 0x001D8E68
		public virtual int GetLineStippleRepeatFactor()
		{
			return vtkProperty2D.vtkProperty2D_GetLineStippleRepeatFactor_09(base.GetCppThis());
		}

		// Token: 0x06014F82 RID: 85890
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProperty2D_GetLineStippleRepeatFactorMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the stippling repeat factor of a Line, which specifies how
		/// many times each bit in the pattern is to be repeated.
		/// This is only implemented for OpenGL, not OpenGL2. The default is 1.
		/// </summary>
		// Token: 0x06014F83 RID: 85891 RVA: 0x001DAC88 File Offset: 0x001D8E88
		public virtual int GetLineStippleRepeatFactorMaxValue()
		{
			return vtkProperty2D.vtkProperty2D_GetLineStippleRepeatFactorMaxValue_10(base.GetCppThis());
		}

		// Token: 0x06014F84 RID: 85892
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProperty2D_GetLineStippleRepeatFactorMinValue_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the stippling repeat factor of a Line, which specifies how
		/// many times each bit in the pattern is to be repeated.
		/// This is only implemented for OpenGL, not OpenGL2. The default is 1.
		/// </summary>
		// Token: 0x06014F85 RID: 85893 RVA: 0x001DACA8 File Offset: 0x001D8EA8
		public virtual int GetLineStippleRepeatFactorMinValue()
		{
			return vtkProperty2D.vtkProperty2D_GetLineStippleRepeatFactorMinValue_11(base.GetCppThis());
		}

		// Token: 0x06014F86 RID: 85894
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkProperty2D_GetLineWidth_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the width of a Line. The width is expressed in screen units.
		/// This is only implemented for OpenGL. The default is 1.0.
		/// </summary>
		// Token: 0x06014F87 RID: 85895 RVA: 0x001DACC8 File Offset: 0x001D8EC8
		public virtual float GetLineWidth()
		{
			return vtkProperty2D.vtkProperty2D_GetLineWidth_12(base.GetCppThis());
		}

		// Token: 0x06014F88 RID: 85896
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkProperty2D_GetLineWidthMaxValue_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the width of a Line. The width is expressed in screen units.
		/// This is only implemented for OpenGL. The default is 1.0.
		/// </summary>
		// Token: 0x06014F89 RID: 85897 RVA: 0x001DACE8 File Offset: 0x001D8EE8
		public virtual float GetLineWidthMaxValue()
		{
			return vtkProperty2D.vtkProperty2D_GetLineWidthMaxValue_13(base.GetCppThis());
		}

		// Token: 0x06014F8A RID: 85898
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkProperty2D_GetLineWidthMinValue_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the width of a Line. The width is expressed in screen units.
		/// This is only implemented for OpenGL. The default is 1.0.
		/// </summary>
		// Token: 0x06014F8B RID: 85899 RVA: 0x001DAD08 File Offset: 0x001D8F08
		public virtual float GetLineWidthMinValue()
		{
			return vtkProperty2D.vtkProperty2D_GetLineWidthMinValue_14(base.GetCppThis());
		}

		// Token: 0x06014F8C RID: 85900
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProperty2D_GetNumberOfGenerationsFromBase_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014F8D RID: 85901 RVA: 0x001DAD28 File Offset: 0x001D8F28
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkProperty2D.vtkProperty2D_GetNumberOfGenerationsFromBase_15(base.GetCppThis(), type);
		}

		// Token: 0x06014F8E RID: 85902
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProperty2D_GetNumberOfGenerationsFromBaseType_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014F8F RID: 85903 RVA: 0x001DAD48 File Offset: 0x001D8F48
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkProperty2D.vtkProperty2D_GetNumberOfGenerationsFromBaseType_16(type);
		}

		// Token: 0x06014F90 RID: 85904
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty2D_GetOpacity_17(HandleRef pThis);

		/// <summary>
		/// Set/Get the Opacity of this property.
		/// </summary>
		// Token: 0x06014F91 RID: 85905 RVA: 0x001DAD64 File Offset: 0x001D8F64
		public virtual double GetOpacity()
		{
			return vtkProperty2D.vtkProperty2D_GetOpacity_17(base.GetCppThis());
		}

		// Token: 0x06014F92 RID: 85906
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkProperty2D_GetPointSize_18(HandleRef pThis);

		/// <summary>
		/// Set/Get the diameter of a Point. The size is expressed in screen units.
		/// This is only implemented for OpenGL. The default is 1.0.
		/// </summary>
		// Token: 0x06014F93 RID: 85907 RVA: 0x001DAD84 File Offset: 0x001D8F84
		public virtual float GetPointSize()
		{
			return vtkProperty2D.vtkProperty2D_GetPointSize_18(base.GetCppThis());
		}

		// Token: 0x06014F94 RID: 85908
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkProperty2D_GetPointSizeMaxValue_19(HandleRef pThis);

		/// <summary>
		/// Set/Get the diameter of a Point. The size is expressed in screen units.
		/// This is only implemented for OpenGL. The default is 1.0.
		/// </summary>
		// Token: 0x06014F95 RID: 85909 RVA: 0x001DADA4 File Offset: 0x001D8FA4
		public virtual float GetPointSizeMaxValue()
		{
			return vtkProperty2D.vtkProperty2D_GetPointSizeMaxValue_19(base.GetCppThis());
		}

		// Token: 0x06014F96 RID: 85910
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkProperty2D_GetPointSizeMinValue_20(HandleRef pThis);

		/// <summary>
		/// Set/Get the diameter of a Point. The size is expressed in screen units.
		/// This is only implemented for OpenGL. The default is 1.0.
		/// </summary>
		// Token: 0x06014F97 RID: 85911 RVA: 0x001DADC4 File Offset: 0x001D8FC4
		public virtual float GetPointSizeMinValue()
		{
			return vtkProperty2D.vtkProperty2D_GetPointSizeMinValue_20(base.GetCppThis());
		}

		// Token: 0x06014F98 RID: 85912
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProperty2D_IsA_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014F99 RID: 85913 RVA: 0x001DADE4 File Offset: 0x001D8FE4
		public override int IsA(string type)
		{
			return vtkProperty2D.vtkProperty2D_IsA_21(base.GetCppThis(), type);
		}

		// Token: 0x06014F9A RID: 85914
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProperty2D_IsTypeOf_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014F9B RID: 85915 RVA: 0x001DAE04 File Offset: 0x001D9004
		public new static int IsTypeOf(string type)
		{
			return vtkProperty2D.vtkProperty2D_IsTypeOf_22(type);
		}

		// Token: 0x06014F9C RID: 85916
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProperty2D_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014F9D RID: 85917 RVA: 0x001DAE20 File Offset: 0x001D9020
		public new vtkProperty2D NewInstance()
		{
			vtkProperty2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProperty2D.vtkProperty2D_NewInstance_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014F9E RID: 85918
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty2D_Render_25(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Have the device specific subclass render this property.
		/// </summary>
		// Token: 0x06014F9F RID: 85919 RVA: 0x001DAE7C File Offset: 0x001D907C
		public virtual void Render(vtkViewport arg0)
		{
			vtkProperty2D.vtkProperty2D_Render_25(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06014FA0 RID: 85920
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProperty2D_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014FA1 RID: 85921 RVA: 0x001DAEAC File Offset: 0x001D90AC
		public new static vtkProperty2D SafeDownCast(vtkObjectBase o)
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProperty2D.vtkProperty2D_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty2D = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty2D.Register(null);
				}
			}
			return vtkProperty2D;
		}

		// Token: 0x06014FA2 RID: 85922
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty2D_SetColor_27(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the RGB color of this property.
		/// </summary>
		// Token: 0x06014FA3 RID: 85923 RVA: 0x001DAF2B File Offset: 0x001D912B
		public virtual void SetColor(double _arg1, double _arg2, double _arg3)
		{
			vtkProperty2D.vtkProperty2D_SetColor_27(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06014FA4 RID: 85924
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty2D_SetColor_28(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the RGB color of this property.
		/// </summary>
		// Token: 0x06014FA5 RID: 85925 RVA: 0x001DAF3D File Offset: 0x001D913D
		public virtual void SetColor(IntPtr _arg)
		{
			vtkProperty2D.vtkProperty2D_SetColor_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06014FA6 RID: 85926
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty2D_SetDisplayLocation_29(HandleRef pThis, int _arg);

		/// <summary>
		/// The DisplayLocation is either background or foreground.
		/// If it is background, then this 2D actor will be drawn
		/// behind all 3D props or foreground 2D actors. If it is
		/// foreground, then this 2D actor will be drawn in front of
		/// all 3D props and background 2D actors. Within 2D actors
		/// of the same DisplayLocation type, order is determined by
		/// the order in which the 2D actors were added to the viewport.
		/// </summary>
		// Token: 0x06014FA7 RID: 85927 RVA: 0x001DAF4D File Offset: 0x001D914D
		public virtual void SetDisplayLocation(int _arg)
		{
			vtkProperty2D.vtkProperty2D_SetDisplayLocation_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06014FA8 RID: 85928
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty2D_SetDisplayLocationToBackground_30(HandleRef pThis);

		/// <summary>
		/// The DisplayLocation is either background or foreground.
		/// If it is background, then this 2D actor will be drawn
		/// behind all 3D props or foreground 2D actors. If it is
		/// foreground, then this 2D actor will be drawn in front of
		/// all 3D props and background 2D actors. Within 2D actors
		/// of the same DisplayLocation type, order is determined by
		/// the order in which the 2D actors were added to the viewport.
		/// </summary>
		// Token: 0x06014FA9 RID: 85929 RVA: 0x001DAF5D File Offset: 0x001D915D
		public void SetDisplayLocationToBackground()
		{
			vtkProperty2D.vtkProperty2D_SetDisplayLocationToBackground_30(base.GetCppThis());
		}

		// Token: 0x06014FAA RID: 85930
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty2D_SetDisplayLocationToForeground_31(HandleRef pThis);

		/// <summary>
		/// The DisplayLocation is either background or foreground.
		/// If it is background, then this 2D actor will be drawn
		/// behind all 3D props or foreground 2D actors. If it is
		/// foreground, then this 2D actor will be drawn in front of
		/// all 3D props and background 2D actors. Within 2D actors
		/// of the same DisplayLocation type, order is determined by
		/// the order in which the 2D actors were added to the viewport.
		/// </summary>
		// Token: 0x06014FAB RID: 85931 RVA: 0x001DAF6C File Offset: 0x001D916C
		public void SetDisplayLocationToForeground()
		{
			vtkProperty2D.vtkProperty2D_SetDisplayLocationToForeground_31(base.GetCppThis());
		}

		// Token: 0x06014FAC RID: 85932
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty2D_SetLineStipplePattern_32(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the stippling pattern of a Line, as a 16-bit binary pattern
		/// (1 = pixel on, 0 = pixel off).
		/// This is only implemented for OpenGL, not OpenGL2. The default is 0xFFFF.
		/// </summary>
		// Token: 0x06014FAD RID: 85933 RVA: 0x001DAF7B File Offset: 0x001D917B
		public virtual void SetLineStipplePattern(int _arg)
		{
			vtkProperty2D.vtkProperty2D_SetLineStipplePattern_32(base.GetCppThis(), _arg);
		}

		// Token: 0x06014FAE RID: 85934
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty2D_SetLineStippleRepeatFactor_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the stippling repeat factor of a Line, which specifies how
		/// many times each bit in the pattern is to be repeated.
		/// This is only implemented for OpenGL, not OpenGL2. The default is 1.
		/// </summary>
		// Token: 0x06014FAF RID: 85935 RVA: 0x001DAF8B File Offset: 0x001D918B
		public virtual void SetLineStippleRepeatFactor(int _arg)
		{
			vtkProperty2D.vtkProperty2D_SetLineStippleRepeatFactor_33(base.GetCppThis(), _arg);
		}

		// Token: 0x06014FB0 RID: 85936
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty2D_SetLineWidth_34(HandleRef pThis, float _arg);

		/// <summary>
		/// Set/Get the width of a Line. The width is expressed in screen units.
		/// This is only implemented for OpenGL. The default is 1.0.
		/// </summary>
		// Token: 0x06014FB1 RID: 85937 RVA: 0x001DAF9B File Offset: 0x001D919B
		public virtual void SetLineWidth(float _arg)
		{
			vtkProperty2D.vtkProperty2D_SetLineWidth_34(base.GetCppThis(), _arg);
		}

		// Token: 0x06014FB2 RID: 85938
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty2D_SetOpacity_35(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the Opacity of this property.
		/// </summary>
		// Token: 0x06014FB3 RID: 85939 RVA: 0x001DAFAB File Offset: 0x001D91AB
		public virtual void SetOpacity(double _arg)
		{
			vtkProperty2D.vtkProperty2D_SetOpacity_35(base.GetCppThis(), _arg);
		}

		// Token: 0x06014FB4 RID: 85940
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty2D_SetPointSize_36(HandleRef pThis, float _arg);

		/// <summary>
		/// Set/Get the diameter of a Point. The size is expressed in screen units.
		/// This is only implemented for OpenGL. The default is 1.0.
		/// </summary>
		// Token: 0x06014FB5 RID: 85941 RVA: 0x001DAFBB File Offset: 0x001D91BB
		public virtual void SetPointSize(float _arg)
		{
			vtkProperty2D.vtkProperty2D_SetPointSize_36(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001836 RID: 6198
		public new const string MRFullTypeName = "Kitware.VTK.vtkProperty2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001837 RID: 6199
		public new static readonly string MRClassNameKey = "class vtkProperty2D";
	}
}
