using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageInterpolator
	/// </summary>
	/// <remarks>
	///    interpolate data values from images
	///
	/// vtkImageInterpolator provides a simple interface for interpolating image
	/// data.  It provides linear, cubic, and nearest-neighbor interpolation.
	/// @par Thanks:
	/// Thanks to David Gobbi at the Seaman Family MR Centre and Dept. of Clinical
	/// Neurosciences, Foothills Medical Centre, Calgary, for providing this class.
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageReslice
	/// </seealso>
	// Token: 0x0200084A RID: 2122
	public class vtkImageInterpolator : vtkAbstractImageInterpolator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601603F RID: 90175 RVA: 0x001EFFF9 File Offset: 0x001EE1F9
		static vtkImageInterpolator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageInterpolator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageInterpolator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016040 RID: 90176 RVA: 0x001F0021 File Offset: 0x001EE221
		public vtkImageInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016041 RID: 90177
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016042 RID: 90178 RVA: 0x001F0030 File Offset: 0x001EE230
		public new static vtkImageInterpolator New()
		{
			vtkImageInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageInterpolator.vtkImageInterpolator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016043 RID: 90179 RVA: 0x001F0084 File Offset: 0x001EE284
		public vtkImageInterpolator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageInterpolator.vtkImageInterpolator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016044 RID: 90180 RVA: 0x001F00C8 File Offset: 0x001EE2C8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016045 RID: 90181
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageInterpolator_ComputeSupportSize_01(HandleRef pThis, IntPtr matrix, IntPtr size);

		/// <summary>
		/// Get the support size for use in computing update extents.  If the data
		/// will be sampled on a regular grid, then pass a matrix describing the
		/// structured coordinate transformation between the output and the input.
		/// Otherwise, pass nullptr as the matrix to retrieve the full kernel size.
		/// </summary>
		// Token: 0x06016046 RID: 90182 RVA: 0x001F00D3 File Offset: 0x001EE2D3
		public override void ComputeSupportSize(IntPtr matrix, IntPtr size)
		{
			vtkImageInterpolator.vtkImageInterpolator_ComputeSupportSize_01(base.GetCppThis(), matrix, size);
		}

		// Token: 0x06016047 RID: 90183
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageInterpolator_GetInterpolationMode_02(HandleRef pThis);

		/// <summary>
		/// The interpolation mode for point scalars (default: linear).  Subclasses
		/// will provide additional interpolation modes, so this is a virtual method.
		/// </summary>
		// Token: 0x06016048 RID: 90184 RVA: 0x001F00E4 File Offset: 0x001EE2E4
		public int GetInterpolationMode()
		{
			return vtkImageInterpolator.vtkImageInterpolator_GetInterpolationMode_02(base.GetCppThis());
		}

		// Token: 0x06016049 RID: 90185
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageInterpolator_GetInterpolationModeAsString_03(HandleRef pThis);

		/// <summary>
		/// The interpolation mode for point scalars (default: linear).  Subclasses
		/// will provide additional interpolation modes, so this is a virtual method.
		/// </summary>
		// Token: 0x0601604A RID: 90186 RVA: 0x001F0104 File Offset: 0x001EE304
		public virtual string GetInterpolationModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkImageInterpolator.vtkImageInterpolator_GetInterpolationModeAsString_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601604B RID: 90187
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageInterpolator_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601604C RID: 90188 RVA: 0x001F0140 File Offset: 0x001EE340
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageInterpolator.vtkImageInterpolator_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601604D RID: 90189
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageInterpolator_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601604E RID: 90190 RVA: 0x001F0160 File Offset: 0x001EE360
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageInterpolator.vtkImageInterpolator_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601604F RID: 90191
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageInterpolator_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016050 RID: 90192 RVA: 0x001F017C File Offset: 0x001EE37C
		public override int IsA(string type)
		{
			return vtkImageInterpolator.vtkImageInterpolator_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06016051 RID: 90193
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkImageInterpolator_IsSeparable_07(HandleRef pThis);

		/// <summary>
		/// Returns true if the interpolator supports weight precomputation.
		/// This will always return true for this interpolator.
		/// </summary>
		// Token: 0x06016052 RID: 90194 RVA: 0x001F019C File Offset: 0x001EE39C
		public override bool IsSeparable()
		{
			return vtkImageInterpolator.vtkImageInterpolator_IsSeparable_07(base.GetCppThis()) != 0;
		}

		// Token: 0x06016053 RID: 90195
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageInterpolator_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016054 RID: 90196 RVA: 0x001F01C4 File Offset: 0x001EE3C4
		public new static int IsTypeOf(string type)
		{
			return vtkImageInterpolator.vtkImageInterpolator_IsTypeOf_08(type);
		}

		// Token: 0x06016055 RID: 90197
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageInterpolator_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016056 RID: 90198 RVA: 0x001F01E0 File Offset: 0x001EE3E0
		public new vtkImageInterpolator NewInstance()
		{
			vtkImageInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageInterpolator.vtkImageInterpolator_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016057 RID: 90199
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageInterpolator_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016058 RID: 90200 RVA: 0x001F023C File Offset: 0x001EE43C
		public new static vtkImageInterpolator SafeDownCast(vtkObjectBase o)
		{
			vtkImageInterpolator vtkImageInterpolator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageInterpolator.vtkImageInterpolator_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageInterpolator = (vtkImageInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageInterpolator.Register(null);
				}
			}
			return vtkImageInterpolator;
		}

		// Token: 0x06016059 RID: 90201
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageInterpolator_SetInterpolationMode_12(HandleRef pThis, int mode);

		/// <summary>
		/// The interpolation mode for point scalars (default: linear).  Subclasses
		/// will provide additional interpolation modes, so this is a virtual method.
		/// </summary>
		// Token: 0x0601605A RID: 90202 RVA: 0x001F02BB File Offset: 0x001EE4BB
		public virtual void SetInterpolationMode(int mode)
		{
			vtkImageInterpolator.vtkImageInterpolator_SetInterpolationMode_12(base.GetCppThis(), mode);
		}

		// Token: 0x0601605B RID: 90203
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageInterpolator_SetInterpolationModeToCubic_13(HandleRef pThis);

		/// <summary>
		/// The interpolation mode for point scalars (default: linear).  Subclasses
		/// will provide additional interpolation modes, so this is a virtual method.
		/// </summary>
		// Token: 0x0601605C RID: 90204 RVA: 0x001F02CB File Offset: 0x001EE4CB
		public void SetInterpolationModeToCubic()
		{
			vtkImageInterpolator.vtkImageInterpolator_SetInterpolationModeToCubic_13(base.GetCppThis());
		}

		// Token: 0x0601605D RID: 90205
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageInterpolator_SetInterpolationModeToLinear_14(HandleRef pThis);

		/// <summary>
		/// The interpolation mode for point scalars (default: linear).  Subclasses
		/// will provide additional interpolation modes, so this is a virtual method.
		/// </summary>
		// Token: 0x0601605E RID: 90206 RVA: 0x001F02DA File Offset: 0x001EE4DA
		public void SetInterpolationModeToLinear()
		{
			vtkImageInterpolator.vtkImageInterpolator_SetInterpolationModeToLinear_14(base.GetCppThis());
		}

		// Token: 0x0601605F RID: 90207
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageInterpolator_SetInterpolationModeToNearest_15(HandleRef pThis);

		/// <summary>
		/// The interpolation mode for point scalars (default: linear).  Subclasses
		/// will provide additional interpolation modes, so this is a virtual method.
		/// </summary>
		// Token: 0x06016060 RID: 90208 RVA: 0x001F02E9 File Offset: 0x001EE4E9
		public void SetInterpolationModeToNearest()
		{
			vtkImageInterpolator.vtkImageInterpolator_SetInterpolationModeToNearest_15(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018E8 RID: 6376
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageInterpolator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018E9 RID: 6377
		public new static readonly string MRClassNameKey = "class vtkImageInterpolator";
	}
}
