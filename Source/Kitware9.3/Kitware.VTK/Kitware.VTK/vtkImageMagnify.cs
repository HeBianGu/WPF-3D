using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageMagnify
	/// </summary>
	/// <remarks>
	///    magnify an image by an integer value
	///
	/// vtkImageMagnify maps each pixel of the input onto a nxmx... region
	/// of the output.  Location (0,0,...) remains in the same place. The
	/// magnification occurs via pixel replication, or if Interpolate is on,
	/// by bilinear interpolation. Initially, interpolation is off and magnification
	/// factors are set to 1 in all directions.
	/// </remarks>
	// Token: 0x0200085A RID: 2138
	public class vtkImageMagnify : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060162D2 RID: 90834 RVA: 0x001F37AF File Offset: 0x001F19AF
		static vtkImageMagnify()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageMagnify.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMagnify"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060162D3 RID: 90835 RVA: 0x001F37D7 File Offset: 0x001F19D7
		public vtkImageMagnify(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060162D4 RID: 90836
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMagnify_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060162D5 RID: 90837 RVA: 0x001F37E8 File Offset: 0x001F19E8
		public new static vtkImageMagnify New()
		{
			vtkImageMagnify result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMagnify.vtkImageMagnify_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMagnify)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060162D6 RID: 90838 RVA: 0x001F383C File Offset: 0x001F1A3C
		public vtkImageMagnify() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageMagnify.vtkImageMagnify_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060162D7 RID: 90839 RVA: 0x001F3880 File Offset: 0x001F1A80
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060162D8 RID: 90840
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMagnify_GetInterpolate_01(HandleRef pThis);

		/// <summary>
		/// Turn interpolation on and off (pixel replication is used when off).
		/// Initially, interpolation is off.
		/// </summary>
		// Token: 0x060162D9 RID: 90841 RVA: 0x001F388C File Offset: 0x001F1A8C
		public virtual int GetInterpolate()
		{
			return vtkImageMagnify.vtkImageMagnify_GetInterpolate_01(base.GetCppThis());
		}

		// Token: 0x060162DA RID: 90842
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMagnify_GetMagnificationFactors_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the integer magnification factors in the i-j-k directions.
		/// Initially, factors are set to 1 in all directions.
		/// </summary>
		// Token: 0x060162DB RID: 90843 RVA: 0x001F38AC File Offset: 0x001F1AAC
		public virtual int[] GetMagnificationFactors()
		{
			IntPtr intPtr = vtkImageMagnify.vtkImageMagnify_GetMagnificationFactors_02(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060162DC RID: 90844
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMagnify_GetMagnificationFactors_03(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		/// <summary>
		/// Set/Get the integer magnification factors in the i-j-k directions.
		/// Initially, factors are set to 1 in all directions.
		/// </summary>
		// Token: 0x060162DD RID: 90845 RVA: 0x001F38F4 File Offset: 0x001F1AF4
		public virtual void GetMagnificationFactors(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkImageMagnify.vtkImageMagnify_GetMagnificationFactors_03(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060162DE RID: 90846
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMagnify_GetMagnificationFactors_04(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the integer magnification factors in the i-j-k directions.
		/// Initially, factors are set to 1 in all directions.
		/// </summary>
		// Token: 0x060162DF RID: 90847 RVA: 0x001F3906 File Offset: 0x001F1B06
		public virtual void GetMagnificationFactors(IntPtr _arg)
		{
			vtkImageMagnify.vtkImageMagnify_GetMagnificationFactors_04(base.GetCppThis(), _arg);
		}

		// Token: 0x060162E0 RID: 90848
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageMagnify_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060162E1 RID: 90849 RVA: 0x001F3918 File Offset: 0x001F1B18
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageMagnify.vtkImageMagnify_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x060162E2 RID: 90850
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageMagnify_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060162E3 RID: 90851 RVA: 0x001F3938 File Offset: 0x001F1B38
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageMagnify.vtkImageMagnify_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x060162E4 RID: 90852
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMagnify_InterpolateOff_07(HandleRef pThis);

		/// <summary>
		/// Turn interpolation on and off (pixel replication is used when off).
		/// Initially, interpolation is off.
		/// </summary>
		// Token: 0x060162E5 RID: 90853 RVA: 0x001F3952 File Offset: 0x001F1B52
		public virtual void InterpolateOff()
		{
			vtkImageMagnify.vtkImageMagnify_InterpolateOff_07(base.GetCppThis());
		}

		// Token: 0x060162E6 RID: 90854
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMagnify_InterpolateOn_08(HandleRef pThis);

		/// <summary>
		/// Turn interpolation on and off (pixel replication is used when off).
		/// Initially, interpolation is off.
		/// </summary>
		// Token: 0x060162E7 RID: 90855 RVA: 0x001F3961 File Offset: 0x001F1B61
		public virtual void InterpolateOn()
		{
			vtkImageMagnify.vtkImageMagnify_InterpolateOn_08(base.GetCppThis());
		}

		// Token: 0x060162E8 RID: 90856
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMagnify_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060162E9 RID: 90857 RVA: 0x001F3970 File Offset: 0x001F1B70
		public override int IsA(string type)
		{
			return vtkImageMagnify.vtkImageMagnify_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x060162EA RID: 90858
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMagnify_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060162EB RID: 90859 RVA: 0x001F3990 File Offset: 0x001F1B90
		public new static int IsTypeOf(string type)
		{
			return vtkImageMagnify.vtkImageMagnify_IsTypeOf_10(type);
		}

		// Token: 0x060162EC RID: 90860
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMagnify_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060162ED RID: 90861 RVA: 0x001F39AC File Offset: 0x001F1BAC
		public new vtkImageMagnify NewInstance()
		{
			vtkImageMagnify result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMagnify.vtkImageMagnify_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMagnify)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060162EE RID: 90862
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMagnify_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060162EF RID: 90863 RVA: 0x001F3A08 File Offset: 0x001F1C08
		public new static vtkImageMagnify SafeDownCast(vtkObjectBase o)
		{
			vtkImageMagnify vtkImageMagnify = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMagnify.vtkImageMagnify_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageMagnify = (vtkImageMagnify)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageMagnify.Register(null);
				}
			}
			return vtkImageMagnify;
		}

		// Token: 0x060162F0 RID: 90864
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMagnify_SetInterpolate_14(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn interpolation on and off (pixel replication is used when off).
		/// Initially, interpolation is off.
		/// </summary>
		// Token: 0x060162F1 RID: 90865 RVA: 0x001F3A87 File Offset: 0x001F1C87
		public virtual void SetInterpolate(int _arg)
		{
			vtkImageMagnify.vtkImageMagnify_SetInterpolate_14(base.GetCppThis(), _arg);
		}

		// Token: 0x060162F2 RID: 90866
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMagnify_SetMagnificationFactors_15(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		/// <summary>
		/// Set/Get the integer magnification factors in the i-j-k directions.
		/// Initially, factors are set to 1 in all directions.
		/// </summary>
		// Token: 0x060162F3 RID: 90867 RVA: 0x001F3A97 File Offset: 0x001F1C97
		public virtual void SetMagnificationFactors(int _arg1, int _arg2, int _arg3)
		{
			vtkImageMagnify.vtkImageMagnify_SetMagnificationFactors_15(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060162F4 RID: 90868
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMagnify_SetMagnificationFactors_16(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the integer magnification factors in the i-j-k directions.
		/// Initially, factors are set to 1 in all directions.
		/// </summary>
		// Token: 0x060162F5 RID: 90869 RVA: 0x001F3AA9 File Offset: 0x001F1CA9
		public virtual void SetMagnificationFactors(IntPtr _arg)
		{
			vtkImageMagnify.vtkImageMagnify_SetMagnificationFactors_16(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001908 RID: 6408
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageMagnify";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001909 RID: 6409
		public new static readonly string MRClassNameKey = "class vtkImageMagnify";
	}
}
