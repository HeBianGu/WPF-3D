using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageLogarithmicScale
	/// </summary>
	/// <remarks>
	///    Passes each pixel through log function.
	///
	/// vtkImageLogarithmicScale passes each pixel through the function
	/// c*log(1+x).  It also handles negative values with the function
	/// -c*log(1-x).
	/// </remarks>
	// Token: 0x02000254 RID: 596
	public class vtkImageLogarithmicScale : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006E36 RID: 28214 RVA: 0x0009EF57 File Offset: 0x0009D157
		static vtkImageLogarithmicScale()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageLogarithmicScale.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageLogarithmicScale"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006E37 RID: 28215 RVA: 0x0009EF7F File Offset: 0x0009D17F
		public vtkImageLogarithmicScale(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006E38 RID: 28216
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageLogarithmicScale_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E39 RID: 28217 RVA: 0x0009EF90 File Offset: 0x0009D190
		public new static vtkImageLogarithmicScale New()
		{
			vtkImageLogarithmicScale result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageLogarithmicScale.vtkImageLogarithmicScale_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageLogarithmicScale)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E3A RID: 28218 RVA: 0x0009EFE4 File Offset: 0x0009D1E4
		public vtkImageLogarithmicScale() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageLogarithmicScale.vtkImageLogarithmicScale_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006E3B RID: 28219 RVA: 0x0009F028 File Offset: 0x0009D228
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006E3C RID: 28220
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageLogarithmicScale_GetConstant_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the scale factor for the logarithmic function.
		/// </summary>
		// Token: 0x06006E3D RID: 28221 RVA: 0x0009F034 File Offset: 0x0009D234
		public virtual double GetConstant()
		{
			return vtkImageLogarithmicScale.vtkImageLogarithmicScale_GetConstant_01(base.GetCppThis());
		}

		// Token: 0x06006E3E RID: 28222
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageLogarithmicScale_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E3F RID: 28223 RVA: 0x0009F054 File Offset: 0x0009D254
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageLogarithmicScale.vtkImageLogarithmicScale_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06006E40 RID: 28224
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageLogarithmicScale_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E41 RID: 28225 RVA: 0x0009F074 File Offset: 0x0009D274
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageLogarithmicScale.vtkImageLogarithmicScale_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06006E42 RID: 28226
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageLogarithmicScale_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E43 RID: 28227 RVA: 0x0009F090 File Offset: 0x0009D290
		public override int IsA(string type)
		{
			return vtkImageLogarithmicScale.vtkImageLogarithmicScale_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06006E44 RID: 28228
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageLogarithmicScale_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E45 RID: 28229 RVA: 0x0009F0B0 File Offset: 0x0009D2B0
		public new static int IsTypeOf(string type)
		{
			return vtkImageLogarithmicScale.vtkImageLogarithmicScale_IsTypeOf_05(type);
		}

		// Token: 0x06006E46 RID: 28230
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageLogarithmicScale_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E47 RID: 28231 RVA: 0x0009F0CC File Offset: 0x0009D2CC
		public new vtkImageLogarithmicScale NewInstance()
		{
			vtkImageLogarithmicScale result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageLogarithmicScale.vtkImageLogarithmicScale_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageLogarithmicScale)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006E48 RID: 28232
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageLogarithmicScale_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E49 RID: 28233 RVA: 0x0009F128 File Offset: 0x0009D328
		public new static vtkImageLogarithmicScale SafeDownCast(vtkObjectBase o)
		{
			vtkImageLogarithmicScale vtkImageLogarithmicScale = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageLogarithmicScale.vtkImageLogarithmicScale_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageLogarithmicScale = (vtkImageLogarithmicScale)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageLogarithmicScale.Register(null);
				}
			}
			return vtkImageLogarithmicScale;
		}

		// Token: 0x06006E4A RID: 28234
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageLogarithmicScale_SetConstant_09(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the scale factor for the logarithmic function.
		/// </summary>
		// Token: 0x06006E4B RID: 28235 RVA: 0x0009F1A7 File Offset: 0x0009D3A7
		public virtual void SetConstant(double _arg)
		{
			vtkImageLogarithmicScale.vtkImageLogarithmicScale_SetConstant_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400099D RID: 2461
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageLogarithmicScale";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400099E RID: 2462
		public new static readonly string MRClassNameKey = "class vtkImageLogarithmicScale";
	}
}
