using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRayCastImageDisplayHelper
	/// </summary>
	/// <remarks>
	///    helper class that draws the image to the screen
	///
	/// This is a helper class for drawing images created from ray casting on the screen.
	/// This is the abstract device-independent superclass.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkUnstructuredGridVolumeRayCastMapper
	/// vtkOpenGLRayCastImageDisplayHelper
	/// </seealso>
	// Token: 0x020000DA RID: 218
	public abstract class vtkRayCastImageDisplayHelper : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06002DF9 RID: 11769 RVA: 0x00043725 File Offset: 0x00041925
		static vtkRayCastImageDisplayHelper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRayCastImageDisplayHelper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRayCastImageDisplayHelper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002DFA RID: 11770 RVA: 0x0004374D File Offset: 0x0004194D
		public vtkRayCastImageDisplayHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06002DFB RID: 11771
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRayCastImageDisplayHelper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002DFC RID: 11772 RVA: 0x0004375C File Offset: 0x0004195C
		public new static vtkRayCastImageDisplayHelper New()
		{
			vtkRayCastImageDisplayHelper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRayCastImageDisplayHelper.vtkRayCastImageDisplayHelper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRayCastImageDisplayHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002DFD RID: 11773 RVA: 0x000437B0 File Offset: 0x000419B0
		public vtkRayCastImageDisplayHelper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRayCastImageDisplayHelper.vtkRayCastImageDisplayHelper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002DFE RID: 11774 RVA: 0x000437F4 File Offset: 0x000419F4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002DFF RID: 11775
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRayCastImageDisplayHelper_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002E00 RID: 11776 RVA: 0x00043800 File Offset: 0x00041A00
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRayCastImageDisplayHelper.vtkRayCastImageDisplayHelper_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06002E01 RID: 11777
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRayCastImageDisplayHelper_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002E02 RID: 11778 RVA: 0x00043820 File Offset: 0x00041A20
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRayCastImageDisplayHelper.vtkRayCastImageDisplayHelper_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06002E03 RID: 11779
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkRayCastImageDisplayHelper_GetPixelScale_03(HandleRef pThis);

		/// <summary>
		/// Set / Get the pixel scale to be applied to the image before display.
		/// Can be set to scale the incoming pixel values - for example the
		/// fixed point mapper uses the unsigned short API but with 15 bit
		/// values so needs a scale of 2.0.
		/// </summary>
		// Token: 0x06002E04 RID: 11780 RVA: 0x0004383C File Offset: 0x00041A3C
		public virtual float GetPixelScale()
		{
			return vtkRayCastImageDisplayHelper.vtkRayCastImageDisplayHelper_GetPixelScale_03(base.GetCppThis());
		}

		// Token: 0x06002E05 RID: 11781
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRayCastImageDisplayHelper_GetPreMultipliedColors_04(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002E06 RID: 11782 RVA: 0x0004385C File Offset: 0x00041A5C
		public virtual int GetPreMultipliedColors()
		{
			return vtkRayCastImageDisplayHelper.vtkRayCastImageDisplayHelper_GetPreMultipliedColors_04(base.GetCppThis());
		}

		// Token: 0x06002E07 RID: 11783
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRayCastImageDisplayHelper_GetPreMultipliedColorsMaxValue_05(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002E08 RID: 11784 RVA: 0x0004387C File Offset: 0x00041A7C
		public virtual int GetPreMultipliedColorsMaxValue()
		{
			return vtkRayCastImageDisplayHelper.vtkRayCastImageDisplayHelper_GetPreMultipliedColorsMaxValue_05(base.GetCppThis());
		}

		// Token: 0x06002E09 RID: 11785
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRayCastImageDisplayHelper_GetPreMultipliedColorsMinValue_06(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002E0A RID: 11786 RVA: 0x0004389C File Offset: 0x00041A9C
		public virtual int GetPreMultipliedColorsMinValue()
		{
			return vtkRayCastImageDisplayHelper.vtkRayCastImageDisplayHelper_GetPreMultipliedColorsMinValue_06(base.GetCppThis());
		}

		// Token: 0x06002E0B RID: 11787
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRayCastImageDisplayHelper_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002E0C RID: 11788 RVA: 0x000438BC File Offset: 0x00041ABC
		public override int IsA(string type)
		{
			return vtkRayCastImageDisplayHelper.vtkRayCastImageDisplayHelper_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06002E0D RID: 11789
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRayCastImageDisplayHelper_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002E0E RID: 11790 RVA: 0x000438DC File Offset: 0x00041ADC
		public new static int IsTypeOf(string type)
		{
			return vtkRayCastImageDisplayHelper.vtkRayCastImageDisplayHelper_IsTypeOf_08(type);
		}

		// Token: 0x06002E0F RID: 11791
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRayCastImageDisplayHelper_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002E10 RID: 11792 RVA: 0x000438F8 File Offset: 0x00041AF8
		public new vtkRayCastImageDisplayHelper NewInstance()
		{
			vtkRayCastImageDisplayHelper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRayCastImageDisplayHelper.vtkRayCastImageDisplayHelper_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRayCastImageDisplayHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06002E11 RID: 11793
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRayCastImageDisplayHelper_PreMultipliedColorsOff_11(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002E12 RID: 11794 RVA: 0x00043952 File Offset: 0x00041B52
		public virtual void PreMultipliedColorsOff()
		{
			vtkRayCastImageDisplayHelper.vtkRayCastImageDisplayHelper_PreMultipliedColorsOff_11(base.GetCppThis());
		}

		// Token: 0x06002E13 RID: 11795
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRayCastImageDisplayHelper_PreMultipliedColorsOn_12(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002E14 RID: 11796 RVA: 0x00043961 File Offset: 0x00041B61
		public virtual void PreMultipliedColorsOn()
		{
			vtkRayCastImageDisplayHelper.vtkRayCastImageDisplayHelper_PreMultipliedColorsOn_12(base.GetCppThis());
		}

		// Token: 0x06002E15 RID: 11797
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRayCastImageDisplayHelper_ReleaseGraphicsResources_13(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Derived class should implement this if needed
		/// </summary>
		// Token: 0x06002E16 RID: 11798 RVA: 0x00043970 File Offset: 0x00041B70
		public virtual void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkRayCastImageDisplayHelper.vtkRayCastImageDisplayHelper_ReleaseGraphicsResources_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002E17 RID: 11799
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRayCastImageDisplayHelper_RenderTexture_14(HandleRef pThis, HandleRef vol, HandleRef ren, IntPtr imageMemorySize, IntPtr imageViewportSize, IntPtr imageInUseSize, IntPtr imageOrigin, float requestedDepth, IntPtr image);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002E18 RID: 11800 RVA: 0x000439A0 File Offset: 0x00041BA0
		public virtual void RenderTexture(vtkVolume vol, vtkRenderer ren, IntPtr imageMemorySize, IntPtr imageViewportSize, IntPtr imageInUseSize, IntPtr imageOrigin, float requestedDepth, IntPtr image)
		{
			vtkRayCastImageDisplayHelper.vtkRayCastImageDisplayHelper_RenderTexture_14(base.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), imageMemorySize, imageViewportSize, imageInUseSize, imageOrigin, requestedDepth, image);
		}

		// Token: 0x06002E19 RID: 11801
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRayCastImageDisplayHelper_RenderTexture_15(HandleRef pThis, HandleRef vol, HandleRef ren, HandleRef image, float requestedDepth);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002E1A RID: 11802 RVA: 0x000439F0 File Offset: 0x00041BF0
		public virtual void RenderTexture(vtkVolume vol, vtkRenderer ren, vtkFixedPointRayCastImage image, float requestedDepth)
		{
			vtkRayCastImageDisplayHelper.vtkRayCastImageDisplayHelper_RenderTexture_15(base.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (image == null) ? default(HandleRef) : image.GetCppThis(), requestedDepth);
		}

		// Token: 0x06002E1B RID: 11803
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRayCastImageDisplayHelper_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002E1C RID: 11804 RVA: 0x00043A4C File Offset: 0x00041C4C
		public new static vtkRayCastImageDisplayHelper SafeDownCast(vtkObjectBase o)
		{
			vtkRayCastImageDisplayHelper vtkRayCastImageDisplayHelper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRayCastImageDisplayHelper.vtkRayCastImageDisplayHelper_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRayCastImageDisplayHelper = (vtkRayCastImageDisplayHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRayCastImageDisplayHelper.Register(null);
				}
			}
			return vtkRayCastImageDisplayHelper;
		}

		// Token: 0x06002E1D RID: 11805
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRayCastImageDisplayHelper_SetPixelScale_17(HandleRef pThis, float _arg);

		/// <summary>
		/// Set / Get the pixel scale to be applied to the image before display.
		/// Can be set to scale the incoming pixel values - for example the
		/// fixed point mapper uses the unsigned short API but with 15 bit
		/// values so needs a scale of 2.0.
		/// </summary>
		// Token: 0x06002E1E RID: 11806 RVA: 0x00043ACB File Offset: 0x00041CCB
		public virtual void SetPixelScale(float _arg)
		{
			vtkRayCastImageDisplayHelper.vtkRayCastImageDisplayHelper_SetPixelScale_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06002E1F RID: 11807
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRayCastImageDisplayHelper_SetPreMultipliedColors_18(HandleRef pThis, int _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002E20 RID: 11808 RVA: 0x00043ADB File Offset: 0x00041CDB
		public virtual void SetPreMultipliedColors(int _arg)
		{
			vtkRayCastImageDisplayHelper.vtkRayCastImageDisplayHelper_SetPreMultipliedColors_18(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005B0 RID: 1456
		public new const string MRFullTypeName = "Kitware.VTK.vtkRayCastImageDisplayHelper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005B1 RID: 1457
		public new static readonly string MRClassNameKey = "class vtkRayCastImageDisplayHelper";
	}
}
