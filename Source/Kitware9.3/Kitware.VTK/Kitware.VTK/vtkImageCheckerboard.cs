using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageCheckerboard
	/// </summary>
	/// <remarks>
	///    show two images at once using a checkboard pattern
	///
	///  vtkImageCheckerboard displays two images as one using a checkerboard
	///  pattern. This filter can be used to compare two images. The
	///  checkerboard pattern is controlled by the NumberOfDivisions
	///  ivar. This controls the number of checkerboard divisions in the whole
	///  extent of the image.
	/// </remarks>
	// Token: 0x0200047F RID: 1151
	public class vtkImageCheckerboard : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D403 RID: 54275 RVA: 0x00126FDB File Offset: 0x001251DB
		static vtkImageCheckerboard()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageCheckerboard.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageCheckerboard"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D404 RID: 54276 RVA: 0x00127003 File Offset: 0x00125203
		public vtkImageCheckerboard(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D405 RID: 54277
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageCheckerboard_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D406 RID: 54278 RVA: 0x00127014 File Offset: 0x00125214
		public new static vtkImageCheckerboard New()
		{
			vtkImageCheckerboard result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageCheckerboard.vtkImageCheckerboard_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageCheckerboard)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D407 RID: 54279 RVA: 0x00127068 File Offset: 0x00125268
		public vtkImageCheckerboard() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageCheckerboard.vtkImageCheckerboard_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D408 RID: 54280 RVA: 0x001270AC File Offset: 0x001252AC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D409 RID: 54281
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageCheckerboard_GetNumberOfDivisions_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of divisions along each axis.
		/// </summary>
		// Token: 0x0600D40A RID: 54282 RVA: 0x001270B8 File Offset: 0x001252B8
		public virtual int[] GetNumberOfDivisions()
		{
			IntPtr intPtr = vtkImageCheckerboard.vtkImageCheckerboard_GetNumberOfDivisions_01(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600D40B RID: 54283
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCheckerboard_GetNumberOfDivisions_02(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the number of divisions along each axis.
		/// </summary>
		// Token: 0x0600D40C RID: 54284 RVA: 0x00127100 File Offset: 0x00125300
		public virtual void GetNumberOfDivisions(IntPtr data)
		{
			vtkImageCheckerboard.vtkImageCheckerboard_GetNumberOfDivisions_02(base.GetCppThis(), data);
		}

		// Token: 0x0600D40D RID: 54285
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageCheckerboard_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D40E RID: 54286 RVA: 0x00127110 File Offset: 0x00125310
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageCheckerboard.vtkImageCheckerboard_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600D40F RID: 54287
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageCheckerboard_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D410 RID: 54288 RVA: 0x00127130 File Offset: 0x00125330
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageCheckerboard.vtkImageCheckerboard_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600D411 RID: 54289
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageCheckerboard_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D412 RID: 54290 RVA: 0x0012714C File Offset: 0x0012534C
		public override int IsA(string type)
		{
			return vtkImageCheckerboard.vtkImageCheckerboard_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600D413 RID: 54291
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageCheckerboard_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D414 RID: 54292 RVA: 0x0012716C File Offset: 0x0012536C
		public new static int IsTypeOf(string type)
		{
			return vtkImageCheckerboard.vtkImageCheckerboard_IsTypeOf_06(type);
		}

		// Token: 0x0600D415 RID: 54293
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageCheckerboard_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D416 RID: 54294 RVA: 0x00127188 File Offset: 0x00125388
		public new vtkImageCheckerboard NewInstance()
		{
			vtkImageCheckerboard result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageCheckerboard.vtkImageCheckerboard_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageCheckerboard)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D417 RID: 54295
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageCheckerboard_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D418 RID: 54296 RVA: 0x001271E4 File Offset: 0x001253E4
		public new static vtkImageCheckerboard SafeDownCast(vtkObjectBase o)
		{
			vtkImageCheckerboard vtkImageCheckerboard = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageCheckerboard.vtkImageCheckerboard_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageCheckerboard = (vtkImageCheckerboard)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageCheckerboard.Register(null);
				}
			}
			return vtkImageCheckerboard;
		}

		// Token: 0x0600D419 RID: 54297
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCheckerboard_SetInput1Data_10(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the two inputs to this filter
		/// </summary>
		// Token: 0x0600D41A RID: 54298 RVA: 0x00127264 File Offset: 0x00125464
		public virtual void SetInput1Data(vtkDataObject arg0)
		{
			vtkImageCheckerboard.vtkImageCheckerboard_SetInput1Data_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600D41B RID: 54299
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCheckerboard_SetInput2Data_11(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the two inputs to this filter
		/// </summary>
		// Token: 0x0600D41C RID: 54300 RVA: 0x00127294 File Offset: 0x00125494
		public virtual void SetInput2Data(vtkDataObject arg0)
		{
			vtkImageCheckerboard.vtkImageCheckerboard_SetInput2Data_11(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600D41D RID: 54301
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCheckerboard_SetNumberOfDivisions_12(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		/// <summary>
		/// Set/Get the number of divisions along each axis.
		/// </summary>
		// Token: 0x0600D41E RID: 54302 RVA: 0x001272C3 File Offset: 0x001254C3
		public virtual void SetNumberOfDivisions(int _arg1, int _arg2, int _arg3)
		{
			vtkImageCheckerboard.vtkImageCheckerboard_SetNumberOfDivisions_12(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600D41F RID: 54303
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCheckerboard_SetNumberOfDivisions_13(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the number of divisions along each axis.
		/// </summary>
		// Token: 0x0600D420 RID: 54304 RVA: 0x001272D5 File Offset: 0x001254D5
		public virtual void SetNumberOfDivisions(IntPtr _arg)
		{
			vtkImageCheckerboard.vtkImageCheckerboard_SetNumberOfDivisions_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FA6 RID: 4006
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageCheckerboard";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FA7 RID: 4007
		public new static readonly string MRClassNameKey = "class vtkImageCheckerboard";
	}
}
