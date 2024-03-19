using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVolume
	/// </summary>
	/// <remarks>
	///    represents a volume (data &amp; properties) in a rendered scene
	///
	///
	/// vtkVolume is used to represent a volumetric entity in a rendering scene.
	/// It inherits functions related to the volume's position, orientation and
	/// origin from vtkProp3D. The volume maintains a reference to the
	/// volumetric data (i.e., the volume mapper). The volume also contains a
	/// reference to a volume property which contains all common volume rendering
	/// parameters.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAbstractVolumeMapper vtkVolumeProperty vtkProp3D
	/// </seealso>
	// Token: 0x0200039D RID: 925
	public class vtkVolume : vtkProp3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A86F RID: 43119 RVA: 0x000EF0C7 File Offset: 0x000ED2C7
		static vtkVolume()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVolume.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolume"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A870 RID: 43120 RVA: 0x000EF0EF File Offset: 0x000ED2EF
		public vtkVolume(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A871 RID: 43121
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolume_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a Volume with the following defaults: origin(0,0,0)
		/// position=(0,0,0) scale=1 visibility=1 pickable=1 dragable=1
		/// orientation=(0,0,0).
		/// </summary>
		// Token: 0x0600A872 RID: 43122 RVA: 0x000EF100 File Offset: 0x000ED300
		public new static vtkVolume New()
		{
			vtkVolume result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolume.vtkVolume_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolume)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a Volume with the following defaults: origin(0,0,0)
		/// position=(0,0,0) scale=1 visibility=1 pickable=1 dragable=1
		/// orientation=(0,0,0).
		/// </summary>
		// Token: 0x0600A873 RID: 43123 RVA: 0x000EF154 File Offset: 0x000ED354
		public vtkVolume() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVolume.vtkVolume_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A874 RID: 43124 RVA: 0x000EF198 File Offset: 0x000ED398
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A875 RID: 43125
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkVolume_GetArraySize_01(HandleRef pThis);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// </summary>
		// Token: 0x0600A876 RID: 43126 RVA: 0x000EF1A4 File Offset: 0x000ED3A4
		public float GetArraySize()
		{
			return vtkVolume.vtkVolume_GetArraySize_01(base.GetCppThis());
		}

		// Token: 0x0600A877 RID: 43127
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolume_GetBounds_02(HandleRef pThis);

		/// <summary>
		/// Get the bounds - either all six at once
		/// (xmin, xmax, ymin, ymax, zmin, zmax) or one at a time.
		/// </summary>
		// Token: 0x0600A878 RID: 43128 RVA: 0x000EF1C4 File Offset: 0x000ED3C4
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkVolume.vtkVolume_GetBounds_02(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600A879 RID: 43129
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolume_GetBounds_03(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Get the bounds - either all six at once
		/// (xmin, xmax, ymin, ymax, zmin, zmax) or one at a time.
		/// </summary>
		// Token: 0x0600A87A RID: 43130 RVA: 0x000EF20C File Offset: 0x000ED40C
		public new void GetBounds(IntPtr bounds)
		{
			vtkVolume.vtkVolume_GetBounds_03(base.GetCppThis(), bounds);
		}

		// Token: 0x0600A87B RID: 43131
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolume_GetCorrectedScalarOpacityArray_04(HandleRef pThis, int arg0);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// </summary>
		// Token: 0x0600A87C RID: 43132 RVA: 0x000EF21C File Offset: 0x000ED41C
		public IntPtr GetCorrectedScalarOpacityArray(int arg0)
		{
			return vtkVolume.vtkVolume_GetCorrectedScalarOpacityArray_04(base.GetCppThis(), arg0);
		}

		// Token: 0x0600A87D RID: 43133
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolume_GetCorrectedScalarOpacityArray_05(HandleRef pThis);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// </summary>
		// Token: 0x0600A87E RID: 43134 RVA: 0x000EF23C File Offset: 0x000ED43C
		public IntPtr GetCorrectedScalarOpacityArray()
		{
			return vtkVolume.vtkVolume_GetCorrectedScalarOpacityArray_05(base.GetCppThis());
		}

		// Token: 0x0600A87F RID: 43135
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolume_GetGradientOpacityArray_06(HandleRef pThis, int arg0);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// </summary>
		// Token: 0x0600A880 RID: 43136 RVA: 0x000EF25C File Offset: 0x000ED45C
		public IntPtr GetGradientOpacityArray(int arg0)
		{
			return vtkVolume.vtkVolume_GetGradientOpacityArray_06(base.GetCppThis(), arg0);
		}

		// Token: 0x0600A881 RID: 43137
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolume_GetGradientOpacityArray_07(HandleRef pThis);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// </summary>
		// Token: 0x0600A882 RID: 43138 RVA: 0x000EF27C File Offset: 0x000ED47C
		public IntPtr GetGradientOpacityArray()
		{
			return vtkVolume.vtkVolume_GetGradientOpacityArray_07(base.GetCppThis());
		}

		// Token: 0x0600A883 RID: 43139
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkVolume_GetGradientOpacityConstant_08(HandleRef pThis, int arg0);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// </summary>
		// Token: 0x0600A884 RID: 43140 RVA: 0x000EF29C File Offset: 0x000ED49C
		public float GetGradientOpacityConstant(int arg0)
		{
			return vtkVolume.vtkVolume_GetGradientOpacityConstant_08(base.GetCppThis(), arg0);
		}

		// Token: 0x0600A885 RID: 43141
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkVolume_GetGradientOpacityConstant_09(HandleRef pThis);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// </summary>
		// Token: 0x0600A886 RID: 43142 RVA: 0x000EF2BC File Offset: 0x000ED4BC
		public float GetGradientOpacityConstant()
		{
			return vtkVolume.vtkVolume_GetGradientOpacityConstant_09(base.GetCppThis());
		}

		// Token: 0x0600A887 RID: 43143
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolume_GetGrayArray_10(HandleRef pThis, int arg0);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// </summary>
		// Token: 0x0600A888 RID: 43144 RVA: 0x000EF2DC File Offset: 0x000ED4DC
		public IntPtr GetGrayArray(int arg0)
		{
			return vtkVolume.vtkVolume_GetGrayArray_10(base.GetCppThis(), arg0);
		}

		// Token: 0x0600A889 RID: 43145
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolume_GetGrayArray_11(HandleRef pThis);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// </summary>
		// Token: 0x0600A88A RID: 43146 RVA: 0x000EF2FC File Offset: 0x000ED4FC
		public IntPtr GetGrayArray()
		{
			return vtkVolume.vtkVolume_GetGrayArray_11(base.GetCppThis());
		}

		// Token: 0x0600A88B RID: 43147
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkVolume_GetMTime_12(HandleRef pThis);

		/// <summary>
		/// Return the MTime also considering the property etc.
		/// </summary>
		// Token: 0x0600A88C RID: 43148 RVA: 0x000EF31C File Offset: 0x000ED51C
		public override ulong GetMTime()
		{
			return vtkVolume.vtkVolume_GetMTime_12(base.GetCppThis());
		}

		// Token: 0x0600A88D RID: 43149
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolume_GetMapper_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the volume mapper.
		/// </summary>
		// Token: 0x0600A88E RID: 43150 RVA: 0x000EF33C File Offset: 0x000ED53C
		public virtual vtkAbstractVolumeMapper GetMapper()
		{
			vtkAbstractVolumeMapper vtkAbstractVolumeMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolume.vtkVolume_GetMapper_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractVolumeMapper = (vtkAbstractVolumeMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractVolumeMapper.Register(null);
				}
			}
			return vtkAbstractVolumeMapper;
		}

		// Token: 0x0600A88F RID: 43151
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVolume_GetMaxXBound_14(HandleRef pThis);

		/// <summary>
		/// Get the bounds - either all six at once
		/// (xmin, xmax, ymin, ymax, zmin, zmax) or one at a time.
		/// </summary>
		// Token: 0x0600A890 RID: 43152 RVA: 0x000EF3AC File Offset: 0x000ED5AC
		public double GetMaxXBound()
		{
			return vtkVolume.vtkVolume_GetMaxXBound_14(base.GetCppThis());
		}

		// Token: 0x0600A891 RID: 43153
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVolume_GetMaxYBound_15(HandleRef pThis);

		/// <summary>
		/// Get the bounds - either all six at once
		/// (xmin, xmax, ymin, ymax, zmin, zmax) or one at a time.
		/// </summary>
		// Token: 0x0600A892 RID: 43154 RVA: 0x000EF3CC File Offset: 0x000ED5CC
		public double GetMaxYBound()
		{
			return vtkVolume.vtkVolume_GetMaxYBound_15(base.GetCppThis());
		}

		// Token: 0x0600A893 RID: 43155
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVolume_GetMaxZBound_16(HandleRef pThis);

		/// <summary>
		/// Get the bounds - either all six at once
		/// (xmin, xmax, ymin, ymax, zmin, zmax) or one at a time.
		/// </summary>
		// Token: 0x0600A894 RID: 43156 RVA: 0x000EF3EC File Offset: 0x000ED5EC
		public double GetMaxZBound()
		{
			return vtkVolume.vtkVolume_GetMaxZBound_16(base.GetCppThis());
		}

		// Token: 0x0600A895 RID: 43157
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVolume_GetMinXBound_17(HandleRef pThis);

		/// <summary>
		/// Get the bounds - either all six at once
		/// (xmin, xmax, ymin, ymax, zmin, zmax) or one at a time.
		/// </summary>
		// Token: 0x0600A896 RID: 43158 RVA: 0x000EF40C File Offset: 0x000ED60C
		public double GetMinXBound()
		{
			return vtkVolume.vtkVolume_GetMinXBound_17(base.GetCppThis());
		}

		// Token: 0x0600A897 RID: 43159
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVolume_GetMinYBound_18(HandleRef pThis);

		/// <summary>
		/// Get the bounds - either all six at once
		/// (xmin, xmax, ymin, ymax, zmin, zmax) or one at a time.
		/// </summary>
		// Token: 0x0600A898 RID: 43160 RVA: 0x000EF42C File Offset: 0x000ED62C
		public double GetMinYBound()
		{
			return vtkVolume.vtkVolume_GetMinYBound_18(base.GetCppThis());
		}

		// Token: 0x0600A899 RID: 43161
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVolume_GetMinZBound_19(HandleRef pThis);

		/// <summary>
		/// Get the bounds - either all six at once
		/// (xmin, xmax, ymin, ymax, zmin, zmax) or one at a time.
		/// </summary>
		// Token: 0x0600A89A RID: 43162 RVA: 0x000EF44C File Offset: 0x000ED64C
		public double GetMinZBound()
		{
			return vtkVolume.vtkVolume_GetMinZBound_19(base.GetCppThis());
		}

		// Token: 0x0600A89B RID: 43163
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVolume_GetNumberOfGenerationsFromBase_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A89C RID: 43164 RVA: 0x000EF46C File Offset: 0x000ED66C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVolume.vtkVolume_GetNumberOfGenerationsFromBase_20(base.GetCppThis(), type);
		}

		// Token: 0x0600A89D RID: 43165
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVolume_GetNumberOfGenerationsFromBaseType_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A89E RID: 43166 RVA: 0x000EF48C File Offset: 0x000ED68C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVolume.vtkVolume_GetNumberOfGenerationsFromBaseType_21(type);
		}

		// Token: 0x0600A89F RID: 43167
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolume_GetProperty_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the volume property.
		/// </summary>
		// Token: 0x0600A8A0 RID: 43168 RVA: 0x000EF4A8 File Offset: 0x000ED6A8
		public virtual vtkVolumeProperty GetProperty()
		{
			vtkVolumeProperty vtkVolumeProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolume.vtkVolume_GetProperty_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeProperty = (vtkVolumeProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeProperty.Register(null);
				}
			}
			return vtkVolumeProperty;
		}

		// Token: 0x0600A8A1 RID: 43169
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolume_GetRGBArray_23(HandleRef pThis, int arg0);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// </summary>
		// Token: 0x0600A8A2 RID: 43170 RVA: 0x000EF518 File Offset: 0x000ED718
		public IntPtr GetRGBArray(int arg0)
		{
			return vtkVolume.vtkVolume_GetRGBArray_23(base.GetCppThis(), arg0);
		}

		// Token: 0x0600A8A3 RID: 43171
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolume_GetRGBArray_24(HandleRef pThis);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// </summary>
		// Token: 0x0600A8A4 RID: 43172 RVA: 0x000EF538 File Offset: 0x000ED738
		public IntPtr GetRGBArray()
		{
			return vtkVolume.vtkVolume_GetRGBArray_24(base.GetCppThis());
		}

		// Token: 0x0600A8A5 RID: 43173
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkVolume_GetRedrawMTime_25(HandleRef pThis);

		/// <summary>
		/// Return the mtime of anything that would cause the rendered image to
		/// appear differently. Usually this involves checking the mtime of the
		/// prop plus anything else it depends on such as properties, mappers,
		/// etc.
		/// </summary>
		// Token: 0x0600A8A6 RID: 43174 RVA: 0x000EF558 File Offset: 0x000ED758
		public override ulong GetRedrawMTime()
		{
			return vtkVolume.vtkVolume_GetRedrawMTime_25(base.GetCppThis());
		}

		// Token: 0x0600A8A7 RID: 43175
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolume_GetScalarOpacityArray_26(HandleRef pThis, int arg0);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// </summary>
		// Token: 0x0600A8A8 RID: 43176 RVA: 0x000EF578 File Offset: 0x000ED778
		public IntPtr GetScalarOpacityArray(int arg0)
		{
			return vtkVolume.vtkVolume_GetScalarOpacityArray_26(base.GetCppThis(), arg0);
		}

		// Token: 0x0600A8A9 RID: 43177
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolume_GetScalarOpacityArray_27(HandleRef pThis);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// </summary>
		// Token: 0x0600A8AA RID: 43178 RVA: 0x000EF598 File Offset: 0x000ED798
		public IntPtr GetScalarOpacityArray()
		{
			return vtkVolume.vtkVolume_GetScalarOpacityArray_27(base.GetCppThis());
		}

		// Token: 0x0600A8AB RID: 43179
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVolume_GetSupportsSelection_28(HandleRef pThis);

		/// <summary>
		/// Used by vtkHardwareSelector to determine if the prop supports hardware
		/// selection.
		///
		/// @warning INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// </summary>
		// Token: 0x0600A8AC RID: 43180 RVA: 0x000EF5B8 File Offset: 0x000ED7B8
		public override bool GetSupportsSelection()
		{
			return vtkVolume.vtkVolume_GetSupportsSelection_28(base.GetCppThis()) != 0;
		}

		// Token: 0x0600A8AD RID: 43181
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolume_GetVolumes_29(HandleRef pThis, HandleRef vc);

		/// <summary>
		/// For some exporters and other other operations we must be
		/// able to collect all the actors or volumes. This method
		/// is used in that process.
		/// </summary>
		// Token: 0x0600A8AE RID: 43182 RVA: 0x000EF5E0 File Offset: 0x000ED7E0
		public override void GetVolumes(vtkPropCollection vc)
		{
			vtkVolume.vtkVolume_GetVolumes_29(base.GetCppThis(), (vc == null) ? default(HandleRef) : vc.GetCppThis());
		}

		// Token: 0x0600A8AF RID: 43183
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolume_IsA_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A8B0 RID: 43184 RVA: 0x000EF610 File Offset: 0x000ED810
		public override int IsA(string type)
		{
			return vtkVolume.vtkVolume_IsA_30(base.GetCppThis(), type);
		}

		// Token: 0x0600A8B1 RID: 43185
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolume_IsTypeOf_31([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A8B2 RID: 43186 RVA: 0x000EF630 File Offset: 0x000ED830
		public new static int IsTypeOf(string type)
		{
			return vtkVolume.vtkVolume_IsTypeOf_31(type);
		}

		// Token: 0x0600A8B3 RID: 43187
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolume_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A8B4 RID: 43188 RVA: 0x000EF64C File Offset: 0x000ED84C
		public new vtkVolume NewInstance()
		{
			vtkVolume result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolume.vtkVolume_NewInstance_33(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolume)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A8B5 RID: 43189
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolume_ReleaseGraphicsResources_34(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Release any graphics resources that are being consumed by this volume.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0600A8B6 RID: 43190 RVA: 0x000EF6A8 File Offset: 0x000ED8A8
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkVolume.vtkVolume_ReleaseGraphicsResources_34(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600A8B7 RID: 43191
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolume_RenderVolumetricGeometry_35(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// Support the standard render methods.
		/// Depending on the mapper type, the volume may be rendered using
		/// this method (FRAMEBUFFER volume such as texture mapping will
		/// be rendered this way)
		/// </summary>
		// Token: 0x0600A8B8 RID: 43192 RVA: 0x000EF6D8 File Offset: 0x000ED8D8
		public override int RenderVolumetricGeometry(vtkViewport viewport)
		{
			return vtkVolume.vtkVolume_RenderVolumetricGeometry_35(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600A8B9 RID: 43193
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolume_SafeDownCast_36(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A8BA RID: 43194 RVA: 0x000EF70C File Offset: 0x000ED90C
		public new static vtkVolume SafeDownCast(vtkObjectBase o)
		{
			vtkVolume vtkVolume = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolume.vtkVolume_SafeDownCast_36((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolume = (vtkVolume)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolume.Register(null);
				}
			}
			return vtkVolume;
		}

		// Token: 0x0600A8BB RID: 43195
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolume_SetMapper_37(HandleRef pThis, HandleRef mapper);

		/// <summary>
		/// Set/Get the volume mapper.
		/// </summary>
		// Token: 0x0600A8BC RID: 43196 RVA: 0x000EF78C File Offset: 0x000ED98C
		public void SetMapper(vtkAbstractVolumeMapper mapper)
		{
			vtkVolume.vtkVolume_SetMapper_37(base.GetCppThis(), (mapper == null) ? default(HandleRef) : mapper.GetCppThis());
		}

		// Token: 0x0600A8BD RID: 43197
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolume_SetProperty_38(HandleRef pThis, HandleRef property);

		/// <summary>
		/// Set/Get the volume property.
		/// </summary>
		// Token: 0x0600A8BE RID: 43198 RVA: 0x000EF7BC File Offset: 0x000ED9BC
		public virtual void SetProperty(vtkVolumeProperty property)
		{
			vtkVolume.vtkVolume_SetProperty_38(base.GetCppThis(), (property == null) ? default(HandleRef) : property.GetCppThis());
		}

		// Token: 0x0600A8BF RID: 43199
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolume_ShallowCopy_39(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Shallow copy of this vtkVolume. Overloads the virtual vtkProp method.
		/// </summary>
		// Token: 0x0600A8C0 RID: 43200 RVA: 0x000EF7EC File Offset: 0x000ED9EC
		public override void ShallowCopy(vtkProp prop)
		{
			vtkVolume.vtkVolume_ShallowCopy_39(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x0600A8C1 RID: 43201
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolume_Update_40(HandleRef pThis);

		/// <summary>
		/// Update the volume rendering pipeline by updating the volume mapper
		/// </summary>
		// Token: 0x0600A8C2 RID: 43202 RVA: 0x000EF81B File Offset: 0x000EDA1B
		public void Update()
		{
			vtkVolume.vtkVolume_Update_40(base.GetCppThis());
		}

		// Token: 0x0600A8C3 RID: 43203
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolume_UpdateScalarOpacityforSampleSize_41(HandleRef pThis, HandleRef ren, float sample_distance);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// </summary>
		// Token: 0x0600A8C4 RID: 43204 RVA: 0x000EF82C File Offset: 0x000EDA2C
		public void UpdateScalarOpacityforSampleSize(vtkRenderer ren, float sample_distance)
		{
			vtkVolume.vtkVolume_UpdateScalarOpacityforSampleSize_41(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), sample_distance);
		}

		// Token: 0x0600A8C5 RID: 43205
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolume_UpdateTransferFunctions_42(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// </summary>
		// Token: 0x0600A8C6 RID: 43206 RVA: 0x000EF85C File Offset: 0x000EDA5C
		public void UpdateTransferFunctions(vtkRenderer ren)
		{
			vtkVolume.vtkVolume_UpdateTransferFunctions_42(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D6F RID: 3439
		public new const string MRFullTypeName = "Kitware.VTK.vtkVolume";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D70 RID: 3440
		public new static readonly string MRClassNameKey = "class vtkVolume";
	}
}
