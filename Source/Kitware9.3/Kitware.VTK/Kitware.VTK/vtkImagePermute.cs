using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImagePermute
	/// </summary>
	/// <remarks>
	///     Permutes axes of input.
	///
	/// vtkImagePermute reorders the axes of the input. Filtered axes specify
	/// the input axes which become X, Y, Z.  The input has to have the
	/// same scalar type of the output. The filter does copy the
	/// data when it executes. This filter is actually a very thin wrapper
	/// around vtkImageReslice.
	/// </remarks>
	// Token: 0x0200085D RID: 2141
	public class vtkImagePermute : vtkImageReslice
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601633E RID: 90942 RVA: 0x001F4117 File Offset: 0x001F2317
		static vtkImagePermute()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImagePermute.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImagePermute"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601633F RID: 90943 RVA: 0x001F413F File Offset: 0x001F233F
		public vtkImagePermute(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016340 RID: 90944
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImagePermute_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016341 RID: 90945 RVA: 0x001F4150 File Offset: 0x001F2350
		public new static vtkImagePermute New()
		{
			vtkImagePermute result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImagePermute.vtkImagePermute_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImagePermute)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016342 RID: 90946 RVA: 0x001F41A4 File Offset: 0x001F23A4
		public vtkImagePermute() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImagePermute.vtkImagePermute_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016343 RID: 90947 RVA: 0x001F41E8 File Offset: 0x001F23E8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016344 RID: 90948
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImagePermute_GetFilteredAxes_01(HandleRef pThis);

		/// <summary>
		/// The filtered axes are the input axes that get relabeled to X,Y,Z.
		/// </summary>
		// Token: 0x06016345 RID: 90949 RVA: 0x001F41F4 File Offset: 0x001F23F4
		public virtual int[] GetFilteredAxes()
		{
			IntPtr intPtr = vtkImagePermute.vtkImagePermute_GetFilteredAxes_01(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06016346 RID: 90950
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePermute_GetFilteredAxes_02(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		/// <summary>
		/// The filtered axes are the input axes that get relabeled to X,Y,Z.
		/// </summary>
		// Token: 0x06016347 RID: 90951 RVA: 0x001F423C File Offset: 0x001F243C
		public virtual void GetFilteredAxes(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkImagePermute.vtkImagePermute_GetFilteredAxes_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06016348 RID: 90952
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePermute_GetFilteredAxes_03(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The filtered axes are the input axes that get relabeled to X,Y,Z.
		/// </summary>
		// Token: 0x06016349 RID: 90953 RVA: 0x001F424E File Offset: 0x001F244E
		public virtual void GetFilteredAxes(IntPtr _arg)
		{
			vtkImagePermute.vtkImagePermute_GetFilteredAxes_03(base.GetCppThis(), _arg);
		}

		// Token: 0x0601634A RID: 90954
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImagePermute_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601634B RID: 90955 RVA: 0x001F4260 File Offset: 0x001F2460
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImagePermute.vtkImagePermute_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601634C RID: 90956
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImagePermute_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601634D RID: 90957 RVA: 0x001F4280 File Offset: 0x001F2480
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImagePermute.vtkImagePermute_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601634E RID: 90958
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImagePermute_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601634F RID: 90959 RVA: 0x001F429C File Offset: 0x001F249C
		public override int IsA(string type)
		{
			return vtkImagePermute.vtkImagePermute_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06016350 RID: 90960
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImagePermute_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016351 RID: 90961 RVA: 0x001F42BC File Offset: 0x001F24BC
		public new static int IsTypeOf(string type)
		{
			return vtkImagePermute.vtkImagePermute_IsTypeOf_07(type);
		}

		// Token: 0x06016352 RID: 90962
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImagePermute_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016353 RID: 90963 RVA: 0x001F42D8 File Offset: 0x001F24D8
		public new vtkImagePermute NewInstance()
		{
			vtkImagePermute result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImagePermute.vtkImagePermute_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImagePermute)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016354 RID: 90964
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImagePermute_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016355 RID: 90965 RVA: 0x001F4334 File Offset: 0x001F2534
		public new static vtkImagePermute SafeDownCast(vtkObjectBase o)
		{
			vtkImagePermute vtkImagePermute = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImagePermute.vtkImagePermute_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImagePermute = (vtkImagePermute)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImagePermute.Register(null);
				}
			}
			return vtkImagePermute;
		}

		// Token: 0x06016356 RID: 90966
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePermute_SetFilteredAxes_11(HandleRef pThis, int x, int y, int z);

		/// <summary>
		/// The filtered axes are the input axes that get relabeled to X,Y,Z.
		/// </summary>
		// Token: 0x06016357 RID: 90967 RVA: 0x001F43B3 File Offset: 0x001F25B3
		public void SetFilteredAxes(int x, int y, int z)
		{
			vtkImagePermute.vtkImagePermute_SetFilteredAxes_11(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06016358 RID: 90968
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePermute_SetFilteredAxes_12(HandleRef pThis, IntPtr xyz);

		/// <summary>
		/// The filtered axes are the input axes that get relabeled to X,Y,Z.
		/// </summary>
		// Token: 0x06016359 RID: 90969 RVA: 0x001F43C5 File Offset: 0x001F25C5
		public void SetFilteredAxes(IntPtr xyz)
		{
			vtkImagePermute.vtkImagePermute_SetFilteredAxes_12(base.GetCppThis(), xyz);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400190E RID: 6414
		public new const string MRFullTypeName = "Kitware.VTK.vtkImagePermute";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400190F RID: 6415
		public new static readonly string MRClassNameKey = "class vtkImagePermute";
	}
}
