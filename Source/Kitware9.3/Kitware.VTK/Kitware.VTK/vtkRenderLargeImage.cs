using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRenderLargeImage
	/// </summary>
	/// <remarks>
	///    Use tiling to generate a large rendering
	///
	/// vtkRenderLargeImage provides methods needed to read a region from a file.
	/// </remarks>
	// Token: 0x02000616 RID: 1558
	public class vtkRenderLargeImage : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010ED8 RID: 69336 RVA: 0x001795D7 File Offset: 0x001777D7
		static vtkRenderLargeImage()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRenderLargeImage.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderLargeImage"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010ED9 RID: 69337 RVA: 0x001795FF File Offset: 0x001777FF
		public vtkRenderLargeImage(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010EDA RID: 69338
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderLargeImage_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010EDB RID: 69339 RVA: 0x00179610 File Offset: 0x00177810
		public new static vtkRenderLargeImage New()
		{
			vtkRenderLargeImage result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderLargeImage.vtkRenderLargeImage_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderLargeImage)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010EDC RID: 69340 RVA: 0x00179664 File Offset: 0x00177864
		public vtkRenderLargeImage() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRenderLargeImage.vtkRenderLargeImage_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010EDD RID: 69341 RVA: 0x001796A8 File Offset: 0x001778A8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010EDE RID: 69342
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderLargeImage_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns which renderer is being used as the source for the pixel data.
		/// </summary>
		// Token: 0x06010EDF RID: 69343 RVA: 0x001796B4 File Offset: 0x001778B4
		public virtual vtkRenderer GetInput()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderLargeImage.vtkRenderLargeImage_GetInput_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06010EE0 RID: 69344
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderLargeImage_GetMagnification_02(HandleRef pThis);

		/// <summary>
		/// The magnification of the current render window
		/// </summary>
		// Token: 0x06010EE1 RID: 69345 RVA: 0x00179724 File Offset: 0x00177924
		public virtual int GetMagnification()
		{
			return vtkRenderLargeImage.vtkRenderLargeImage_GetMagnification_02(base.GetCppThis());
		}

		// Token: 0x06010EE2 RID: 69346
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderLargeImage_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010EE3 RID: 69347 RVA: 0x00179744 File Offset: 0x00177944
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRenderLargeImage.vtkRenderLargeImage_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06010EE4 RID: 69348
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderLargeImage_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010EE5 RID: 69349 RVA: 0x00179764 File Offset: 0x00177964
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRenderLargeImage.vtkRenderLargeImage_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06010EE6 RID: 69350
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderLargeImage_GetOutput_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06010EE7 RID: 69351 RVA: 0x00179780 File Offset: 0x00177980
		public vtkImageData GetOutput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderLargeImage.vtkRenderLargeImage_GetOutput_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06010EE8 RID: 69352
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderLargeImage_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010EE9 RID: 69353 RVA: 0x001797F0 File Offset: 0x001779F0
		public override int IsA(string type)
		{
			return vtkRenderLargeImage.vtkRenderLargeImage_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06010EEA RID: 69354
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderLargeImage_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010EEB RID: 69355 RVA: 0x00179810 File Offset: 0x00177A10
		public new static int IsTypeOf(string type)
		{
			return vtkRenderLargeImage.vtkRenderLargeImage_IsTypeOf_07(type);
		}

		// Token: 0x06010EEC RID: 69356
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderLargeImage_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010EED RID: 69357 RVA: 0x0017982C File Offset: 0x00177A2C
		public new vtkRenderLargeImage NewInstance()
		{
			vtkRenderLargeImage result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderLargeImage.vtkRenderLargeImage_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderLargeImage)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010EEE RID: 69358
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderLargeImage_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010EEF RID: 69359 RVA: 0x00179888 File Offset: 0x00177A88
		public new static vtkRenderLargeImage SafeDownCast(vtkObjectBase o)
		{
			vtkRenderLargeImage vtkRenderLargeImage = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderLargeImage.vtkRenderLargeImage_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderLargeImage = (vtkRenderLargeImage)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderLargeImage.Register(null);
				}
			}
			return vtkRenderLargeImage;
		}

		// Token: 0x06010EF0 RID: 69360
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderLargeImage_SetInput_11(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Indicates what renderer to get the pixel data from.
		/// </summary>
		// Token: 0x06010EF1 RID: 69361 RVA: 0x00179908 File Offset: 0x00177B08
		public virtual void SetInput(vtkRenderer arg0)
		{
			vtkRenderLargeImage.vtkRenderLargeImage_SetInput_11(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06010EF2 RID: 69362
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderLargeImage_SetMagnification_12(HandleRef pThis, int _arg);

		/// <summary>
		/// The magnification of the current render window
		/// </summary>
		// Token: 0x06010EF3 RID: 69363 RVA: 0x00179937 File Offset: 0x00177B37
		public virtual void SetMagnification(int _arg)
		{
			vtkRenderLargeImage.vtkRenderLargeImage_SetMagnification_12(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400138B RID: 5003
		public new const string MRFullTypeName = "Kitware.VTK.vtkRenderLargeImage";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400138C RID: 5004
		public new static readonly string MRClassNameKey = "class vtkRenderLargeImage";
	}
}
