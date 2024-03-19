using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRendererSource
	/// </summary>
	/// <remarks>
	///    take a renderer's image and/or depth map into the pipeline
	///
	///
	/// vtkRendererSource is a source object whose input is a renderer's image
	/// and/or depth map, which is then used to produce an output image. This
	/// output can then be used in the visualization pipeline. You must explicitly
	/// send a Modify() to this object to get it to reload its data from the
	/// renderer. Consider also using vtkWindowToImageFilter instead of this
	/// class.
	///
	/// By default, the data placed into the output is the renderer's image RGB
	/// values (these color scalars are represented by unsigned chars, one per
	/// color channel). Optionally, you can also grab the image depth (e.g.,
	/// z-buffer) values, and include it in the output in one of three ways. 1)
	/// First, when the data member DepthValues is enabled, a separate float array
	/// of these depth values is included in the output point data with array name
	/// "ZBuffer". 2) If DepthValuesInScalars is enabled, then the z-buffer values
	/// are shifted and scaled to fit into an unsigned char and included in the
	/// output image (so the output image pixels are four components RGBZ). Note
	/// that DepthValues and and DepthValuesInScalars can be enabled
	/// simultaneously if desired. Finally 3) if DepthValuesOnly is enabled, then
	/// the output image consists only of the z-buffer values represented by a
	/// single component float array; and the data members DepthValues and
	/// DepthValuesInScalars are ignored.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkWindowToImageFilter vtkRendererPointCloudSource vtkRenderer
	/// vtkImageData vtkDepthImageToPointCloud
	/// </seealso>
	// Token: 0x020007FD RID: 2045
	public class vtkRendererSource : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014FFF RID: 86015 RVA: 0x001DB80D File Offset: 0x001D9A0D
		static vtkRendererSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRendererSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRendererSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015000 RID: 86016 RVA: 0x001DB835 File Offset: 0x001D9A35
		public vtkRendererSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06015001 RID: 86017
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRendererSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015002 RID: 86018 RVA: 0x001DB844 File Offset: 0x001D9A44
		public new static vtkRendererSource New()
		{
			vtkRendererSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRendererSource.vtkRendererSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRendererSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015003 RID: 86019 RVA: 0x001DB898 File Offset: 0x001D9A98
		public vtkRendererSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRendererSource.vtkRendererSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015004 RID: 86020 RVA: 0x001DB8DC File Offset: 0x001D9ADC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015005 RID: 86021
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRendererSource_DepthValuesInScalarsOff_01(HandleRef pThis);

		/// <summary>
		/// A boolean value to control whether to grab z-buffer
		/// (i.e., depth values) along with the image data. The z-buffer data
		/// is placed in the scalars as a fourth Z component (shift and scaled
		/// to map the full 0..255 range).
		/// </summary>
		// Token: 0x06015006 RID: 86022 RVA: 0x001DB8E7 File Offset: 0x001D9AE7
		public virtual void DepthValuesInScalarsOff()
		{
			vtkRendererSource.vtkRendererSource_DepthValuesInScalarsOff_01(base.GetCppThis());
		}

		// Token: 0x06015007 RID: 86023
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRendererSource_DepthValuesInScalarsOn_02(HandleRef pThis);

		/// <summary>
		/// A boolean value to control whether to grab z-buffer
		/// (i.e., depth values) along with the image data. The z-buffer data
		/// is placed in the scalars as a fourth Z component (shift and scaled
		/// to map the full 0..255 range).
		/// </summary>
		// Token: 0x06015008 RID: 86024 RVA: 0x001DB8F6 File Offset: 0x001D9AF6
		public virtual void DepthValuesInScalarsOn()
		{
			vtkRendererSource.vtkRendererSource_DepthValuesInScalarsOn_02(base.GetCppThis());
		}

		// Token: 0x06015009 RID: 86025
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRendererSource_DepthValuesOff_03(HandleRef pThis);

		/// <summary>
		/// A boolean value to control whether to grab z-buffer
		/// (i.e., depth values) along with the image data. The z-buffer data
		/// is placed into a field data attributes named "ZBuffer" .
		/// </summary>
		// Token: 0x0601500A RID: 86026 RVA: 0x001DB905 File Offset: 0x001D9B05
		public virtual void DepthValuesOff()
		{
			vtkRendererSource.vtkRendererSource_DepthValuesOff_03(base.GetCppThis());
		}

		// Token: 0x0601500B RID: 86027
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRendererSource_DepthValuesOn_04(HandleRef pThis);

		/// <summary>
		/// A boolean value to control whether to grab z-buffer
		/// (i.e., depth values) along with the image data. The z-buffer data
		/// is placed into a field data attributes named "ZBuffer" .
		/// </summary>
		// Token: 0x0601500C RID: 86028 RVA: 0x001DB914 File Offset: 0x001D9B14
		public virtual void DepthValuesOn()
		{
			vtkRendererSource.vtkRendererSource_DepthValuesOn_04(base.GetCppThis());
		}

		// Token: 0x0601500D RID: 86029
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRendererSource_DepthValuesOnlyOff_05(HandleRef pThis);

		/// <summary>
		/// A boolean value to control whether to grab only the z-buffer (i.e.,
		/// depth values) without the associated image (color scalars) data. If
		/// enabled, the output data contains only a depth image which is the
		/// z-buffer values represented by float values. By default, this is
		/// disabled. Note that if enabled, then the DepthValues and
		/// DepthValuesInScalars are ignored.
		/// </summary>
		// Token: 0x0601500E RID: 86030 RVA: 0x001DB923 File Offset: 0x001D9B23
		public virtual void DepthValuesOnlyOff()
		{
			vtkRendererSource.vtkRendererSource_DepthValuesOnlyOff_05(base.GetCppThis());
		}

		// Token: 0x0601500F RID: 86031
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRendererSource_DepthValuesOnlyOn_06(HandleRef pThis);

		/// <summary>
		/// A boolean value to control whether to grab only the z-buffer (i.e.,
		/// depth values) without the associated image (color scalars) data. If
		/// enabled, the output data contains only a depth image which is the
		/// z-buffer values represented by float values. By default, this is
		/// disabled. Note that if enabled, then the DepthValues and
		/// DepthValuesInScalars are ignored.
		/// </summary>
		// Token: 0x06015010 RID: 86032 RVA: 0x001DB932 File Offset: 0x001D9B32
		public virtual void DepthValuesOnlyOn()
		{
			vtkRendererSource.vtkRendererSource_DepthValuesOnlyOn_06(base.GetCppThis());
		}

		// Token: 0x06015011 RID: 86033
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRendererSource_GetDepthValues_07(HandleRef pThis);

		/// <summary>
		/// A boolean value to control whether to grab z-buffer
		/// (i.e., depth values) along with the image data. The z-buffer data
		/// is placed into a field data attributes named "ZBuffer" .
		/// </summary>
		// Token: 0x06015012 RID: 86034 RVA: 0x001DB944 File Offset: 0x001D9B44
		public virtual int GetDepthValues()
		{
			return vtkRendererSource.vtkRendererSource_GetDepthValues_07(base.GetCppThis());
		}

		// Token: 0x06015013 RID: 86035
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRendererSource_GetDepthValuesInScalars_08(HandleRef pThis);

		/// <summary>
		/// A boolean value to control whether to grab z-buffer
		/// (i.e., depth values) along with the image data. The z-buffer data
		/// is placed in the scalars as a fourth Z component (shift and scaled
		/// to map the full 0..255 range).
		/// </summary>
		// Token: 0x06015014 RID: 86036 RVA: 0x001DB964 File Offset: 0x001D9B64
		public virtual int GetDepthValuesInScalars()
		{
			return vtkRendererSource.vtkRendererSource_GetDepthValuesInScalars_08(base.GetCppThis());
		}

		// Token: 0x06015015 RID: 86037
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRendererSource_GetDepthValuesOnly_09(HandleRef pThis);

		/// <summary>
		/// A boolean value to control whether to grab only the z-buffer (i.e.,
		/// depth values) without the associated image (color scalars) data. If
		/// enabled, the output data contains only a depth image which is the
		/// z-buffer values represented by float values. By default, this is
		/// disabled. Note that if enabled, then the DepthValues and
		/// DepthValuesInScalars are ignored.
		/// </summary>
		// Token: 0x06015016 RID: 86038 RVA: 0x001DB984 File Offset: 0x001D9B84
		public virtual int GetDepthValuesOnly()
		{
			return vtkRendererSource.vtkRendererSource_GetDepthValuesOnly_09(base.GetCppThis());
		}

		// Token: 0x06015017 RID: 86039
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRendererSource_GetInput_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns which renderer is being used as the source for the pixel data.
		/// </summary>
		// Token: 0x06015018 RID: 86040 RVA: 0x001DB9A4 File Offset: 0x001D9BA4
		public virtual vtkRenderer GetInput()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRendererSource.vtkRendererSource_GetInput_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderer = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderer.Register(null);
				}
			}
			return vtkRenderer;
		}

		// Token: 0x06015019 RID: 86041
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkRendererSource_GetMTime_11(HandleRef pThis);

		/// <summary>
		/// Return the MTime also considering the Renderer.
		/// </summary>
		// Token: 0x0601501A RID: 86042 RVA: 0x001DBA14 File Offset: 0x001D9C14
		public override ulong GetMTime()
		{
			return vtkRendererSource.vtkRendererSource_GetMTime_11(base.GetCppThis());
		}

		// Token: 0x0601501B RID: 86043
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRendererSource_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601501C RID: 86044 RVA: 0x001DBA34 File Offset: 0x001D9C34
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRendererSource.vtkRendererSource_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x0601501D RID: 86045
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRendererSource_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601501E RID: 86046 RVA: 0x001DBA54 File Offset: 0x001D9C54
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRendererSource.vtkRendererSource_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x0601501F RID: 86047
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRendererSource_GetOutput_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06015020 RID: 86048 RVA: 0x001DBA70 File Offset: 0x001D9C70
		public vtkImageData GetOutput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRendererSource.vtkRendererSource_GetOutput_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x06015021 RID: 86049
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRendererSource_GetRenderFlag_15(HandleRef pThis);

		/// <summary>
		/// If this flag is on, then filter execution causes a render first.
		/// </summary>
		// Token: 0x06015022 RID: 86050 RVA: 0x001DBAE0 File Offset: 0x001D9CE0
		public virtual int GetRenderFlag()
		{
			return vtkRendererSource.vtkRendererSource_GetRenderFlag_15(base.GetCppThis());
		}

		// Token: 0x06015023 RID: 86051
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRendererSource_GetWholeWindow_16(HandleRef pThis);

		/// <summary>
		/// Use the entire RenderWindow as a data source or just the Renderer.
		/// The default is zero, just the Renderer.
		/// </summary>
		// Token: 0x06015024 RID: 86052 RVA: 0x001DBB00 File Offset: 0x001D9D00
		public virtual int GetWholeWindow()
		{
			return vtkRendererSource.vtkRendererSource_GetWholeWindow_16(base.GetCppThis());
		}

		// Token: 0x06015025 RID: 86053
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRendererSource_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015026 RID: 86054 RVA: 0x001DBB20 File Offset: 0x001D9D20
		public override int IsA(string type)
		{
			return vtkRendererSource.vtkRendererSource_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x06015027 RID: 86055
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRendererSource_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015028 RID: 86056 RVA: 0x001DBB40 File Offset: 0x001D9D40
		public new static int IsTypeOf(string type)
		{
			return vtkRendererSource.vtkRendererSource_IsTypeOf_18(type);
		}

		// Token: 0x06015029 RID: 86057
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRendererSource_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601502A RID: 86058 RVA: 0x001DBB5C File Offset: 0x001D9D5C
		public new vtkRendererSource NewInstance()
		{
			vtkRendererSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRendererSource.vtkRendererSource_NewInstance_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRendererSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601502B RID: 86059
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRendererSource_RenderFlagOff_21(HandleRef pThis);

		/// <summary>
		/// If this flag is on, then filter execution causes a render first.
		/// </summary>
		// Token: 0x0601502C RID: 86060 RVA: 0x001DBBB6 File Offset: 0x001D9DB6
		public virtual void RenderFlagOff()
		{
			vtkRendererSource.vtkRendererSource_RenderFlagOff_21(base.GetCppThis());
		}

		// Token: 0x0601502D RID: 86061
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRendererSource_RenderFlagOn_22(HandleRef pThis);

		/// <summary>
		/// If this flag is on, then filter execution causes a render first.
		/// </summary>
		// Token: 0x0601502E RID: 86062 RVA: 0x001DBBC5 File Offset: 0x001D9DC5
		public virtual void RenderFlagOn()
		{
			vtkRendererSource.vtkRendererSource_RenderFlagOn_22(base.GetCppThis());
		}

		// Token: 0x0601502F RID: 86063
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRendererSource_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015030 RID: 86064 RVA: 0x001DBBD4 File Offset: 0x001D9DD4
		public new static vtkRendererSource SafeDownCast(vtkObjectBase o)
		{
			vtkRendererSource vtkRendererSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRendererSource.vtkRendererSource_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRendererSource = (vtkRendererSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRendererSource.Register(null);
				}
			}
			return vtkRendererSource;
		}

		// Token: 0x06015031 RID: 86065
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRendererSource_SetDepthValues_24(HandleRef pThis, int _arg);

		/// <summary>
		/// A boolean value to control whether to grab z-buffer
		/// (i.e., depth values) along with the image data. The z-buffer data
		/// is placed into a field data attributes named "ZBuffer" .
		/// </summary>
		// Token: 0x06015032 RID: 86066 RVA: 0x001DBC53 File Offset: 0x001D9E53
		public virtual void SetDepthValues(int _arg)
		{
			vtkRendererSource.vtkRendererSource_SetDepthValues_24(base.GetCppThis(), _arg);
		}

		// Token: 0x06015033 RID: 86067
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRendererSource_SetDepthValuesInScalars_25(HandleRef pThis, int _arg);

		/// <summary>
		/// A boolean value to control whether to grab z-buffer
		/// (i.e., depth values) along with the image data. The z-buffer data
		/// is placed in the scalars as a fourth Z component (shift and scaled
		/// to map the full 0..255 range).
		/// </summary>
		// Token: 0x06015034 RID: 86068 RVA: 0x001DBC63 File Offset: 0x001D9E63
		public virtual void SetDepthValuesInScalars(int _arg)
		{
			vtkRendererSource.vtkRendererSource_SetDepthValuesInScalars_25(base.GetCppThis(), _arg);
		}

		// Token: 0x06015035 RID: 86069
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRendererSource_SetDepthValuesOnly_26(HandleRef pThis, int _arg);

		/// <summary>
		/// A boolean value to control whether to grab only the z-buffer (i.e.,
		/// depth values) without the associated image (color scalars) data. If
		/// enabled, the output data contains only a depth image which is the
		/// z-buffer values represented by float values. By default, this is
		/// disabled. Note that if enabled, then the DepthValues and
		/// DepthValuesInScalars are ignored.
		/// </summary>
		// Token: 0x06015036 RID: 86070 RVA: 0x001DBC73 File Offset: 0x001D9E73
		public virtual void SetDepthValuesOnly(int _arg)
		{
			vtkRendererSource.vtkRendererSource_SetDepthValuesOnly_26(base.GetCppThis(), _arg);
		}

		// Token: 0x06015037 RID: 86071
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRendererSource_SetInput_27(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Indicates what renderer to get the pixel data from.
		/// </summary>
		// Token: 0x06015038 RID: 86072 RVA: 0x001DBC84 File Offset: 0x001D9E84
		public void SetInput(vtkRenderer arg0)
		{
			vtkRendererSource.vtkRendererSource_SetInput_27(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06015039 RID: 86073
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRendererSource_SetRenderFlag_28(HandleRef pThis, int _arg);

		/// <summary>
		/// If this flag is on, then filter execution causes a render first.
		/// </summary>
		// Token: 0x0601503A RID: 86074 RVA: 0x001DBCB3 File Offset: 0x001D9EB3
		public virtual void SetRenderFlag(int _arg)
		{
			vtkRendererSource.vtkRendererSource_SetRenderFlag_28(base.GetCppThis(), _arg);
		}

		// Token: 0x0601503B RID: 86075
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRendererSource_SetWholeWindow_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Use the entire RenderWindow as a data source or just the Renderer.
		/// The default is zero, just the Renderer.
		/// </summary>
		// Token: 0x0601503C RID: 86076 RVA: 0x001DBCC3 File Offset: 0x001D9EC3
		public virtual void SetWholeWindow(int _arg)
		{
			vtkRendererSource.vtkRendererSource_SetWholeWindow_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0601503D RID: 86077
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRendererSource_WholeWindowOff_30(HandleRef pThis);

		/// <summary>
		/// Use the entire RenderWindow as a data source or just the Renderer.
		/// The default is zero, just the Renderer.
		/// </summary>
		// Token: 0x0601503E RID: 86078 RVA: 0x001DBCD3 File Offset: 0x001D9ED3
		public virtual void WholeWindowOff()
		{
			vtkRendererSource.vtkRendererSource_WholeWindowOff_30(base.GetCppThis());
		}

		// Token: 0x0601503F RID: 86079
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRendererSource_WholeWindowOn_31(HandleRef pThis);

		/// <summary>
		/// Use the entire RenderWindow as a data source or just the Renderer.
		/// The default is zero, just the Renderer.
		/// </summary>
		// Token: 0x06015040 RID: 86080 RVA: 0x001DBCE2 File Offset: 0x001D9EE2
		public virtual void WholeWindowOn()
		{
			vtkRendererSource.vtkRendererSource_WholeWindowOn_31(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400183E RID: 6206
		public new const string MRFullTypeName = "Kitware.VTK.vtkRendererSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400183F RID: 6207
		public new static readonly string MRClassNameKey = "class vtkRendererSource";
	}
}
