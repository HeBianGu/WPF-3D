using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBrush
	/// </summary>
	/// <remarks>
	///    provides a brush that fills shapes drawn by vtkContext2D.
	///
	///
	/// The vtkBrush defines the fill (or pattern) of shapes that are drawn by
	/// vtkContext2D. The color is stored as four unsigned chars (RGBA), where the
	/// opacity defaults to 255, but can be modified separately to the other
	/// components. Ideally we would use a lightweight color class to store and pass
	/// around colors.
	/// </remarks>
	// Token: 0x020007AA RID: 1962
	public class vtkBrush : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060141F1 RID: 82417 RVA: 0x001C6E6D File Offset: 0x001C506D
		static vtkBrush()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBrush.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBrush"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060141F2 RID: 82418 RVA: 0x001C6E95 File Offset: 0x001C5095
		public vtkBrush(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060141F3 RID: 82419
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBrush_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060141F4 RID: 82420 RVA: 0x001C6EA4 File Offset: 0x001C50A4
		public new static vtkBrush New()
		{
			vtkBrush result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBrush.vtkBrush_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBrush)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060141F5 RID: 82421 RVA: 0x001C6EF8 File Offset: 0x001C50F8
		public vtkBrush() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBrush.vtkBrush_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060141F6 RID: 82422 RVA: 0x001C6F3C File Offset: 0x001C513C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060141F7 RID: 82423
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrush_DeepCopy_01(HandleRef pThis, HandleRef brush);

		/// <summary>
		/// Make a deep copy of the supplied brush.
		/// </summary>
		// Token: 0x060141F8 RID: 82424 RVA: 0x001C6F48 File Offset: 0x001C5148
		public void DeepCopy(vtkBrush brush)
		{
			vtkBrush.vtkBrush_DeepCopy_01(base.GetCppThis(), (brush == null) ? default(HandleRef) : brush.GetCppThis());
		}

		// Token: 0x060141F9 RID: 82425
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrush_GetColor_02(HandleRef pThis, IntPtr color);

		/// <summary>
		/// Get the color of the brush - expects an unsigned char of length 4.
		/// </summary>
		// Token: 0x060141FA RID: 82426 RVA: 0x001C6F77 File Offset: 0x001C5177
		public void GetColor(IntPtr color)
		{
			vtkBrush.vtkBrush_GetColor_02(base.GetCppThis(), color);
		}

		// Token: 0x060141FB RID: 82427
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBrush_GetColor_03(HandleRef pThis);

		/// <summary>
		/// Get the color of the brush - gives a pointer to the underlying data.
		/// </summary>
		// Token: 0x060141FC RID: 82428 RVA: 0x001C6F88 File Offset: 0x001C5188
		public IntPtr GetColor()
		{
			return vtkBrush.vtkBrush_GetColor_03(base.GetCppThis());
		}

		// Token: 0x060141FD RID: 82429
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrush_GetColorF_04(HandleRef pThis, IntPtr color);

		/// <summary>
		/// Get the color of the brush - expects a double of length 4 to copy into.
		/// </summary>
		// Token: 0x060141FE RID: 82430 RVA: 0x001C6FA7 File Offset: 0x001C51A7
		public void GetColorF(IntPtr color)
		{
			vtkBrush.vtkBrush_GetColorF_04(base.GetCppThis(), color);
		}

		// Token: 0x060141FF RID: 82431
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBrush_GetColorObject_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the color of the brush.
		/// </summary>
		// Token: 0x06014200 RID: 82432 RVA: 0x001C6FB8 File Offset: 0x001C51B8
		public vtkColor4ub GetColorObject()
		{
			vtkColor4ub result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBrush.vtkBrush_GetColorObject_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColor4ub)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014201 RID: 82433
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBrush_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014202 RID: 82434 RVA: 0x001C7014 File Offset: 0x001C5214
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBrush.vtkBrush_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06014203 RID: 82435
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBrush_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014204 RID: 82436 RVA: 0x001C7034 File Offset: 0x001C5234
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBrush.vtkBrush_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06014205 RID: 82437
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkBrush_GetOpacity_08(HandleRef pThis);

		/// <summary>
		/// Get the opacity ranging from 0 (transparent) to 255(opaque).
		/// </summary>
		// Token: 0x06014206 RID: 82438 RVA: 0x001C7050 File Offset: 0x001C5250
		public byte GetOpacity()
		{
			return vtkBrush.vtkBrush_GetOpacity_08(base.GetCppThis());
		}

		// Token: 0x06014207 RID: 82439
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkBrush_GetOpacityF_09(HandleRef pThis);

		/// <summary>
		/// Get the opacity ranging from 0.0 (transparent) to 1.0(opaque).
		/// </summary>
		// Token: 0x06014208 RID: 82440 RVA: 0x001C7070 File Offset: 0x001C5270
		public double GetOpacityF()
		{
			return vtkBrush.vtkBrush_GetOpacityF_09(base.GetCppThis());
		}

		// Token: 0x06014209 RID: 82441
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBrush_GetTexture_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the texture that is used to fill polygons
		/// </summary>
		// Token: 0x0601420A RID: 82442 RVA: 0x001C7090 File Offset: 0x001C5290
		public virtual vtkImageData GetTexture()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBrush.vtkBrush_GetTexture_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601420B RID: 82443
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBrush_GetTextureProperties_11(HandleRef pThis);

		/// <summary>
		/// Get the properties associated to the texture
		/// </summary>
		// Token: 0x0601420C RID: 82444 RVA: 0x001C7100 File Offset: 0x001C5300
		public virtual int GetTextureProperties()
		{
			return vtkBrush.vtkBrush_GetTextureProperties_11(base.GetCppThis());
		}

		// Token: 0x0601420D RID: 82445
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBrush_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601420E RID: 82446 RVA: 0x001C7120 File Offset: 0x001C5320
		public override int IsA(string type)
		{
			return vtkBrush.vtkBrush_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x0601420F RID: 82447
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBrush_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014210 RID: 82448 RVA: 0x001C7140 File Offset: 0x001C5340
		public new static int IsTypeOf(string type)
		{
			return vtkBrush.vtkBrush_IsTypeOf_13(type);
		}

		// Token: 0x06014211 RID: 82449
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBrush_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014212 RID: 82450 RVA: 0x001C715C File Offset: 0x001C535C
		public new vtkBrush NewInstance()
		{
			vtkBrush result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBrush.vtkBrush_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBrush)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014213 RID: 82451
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBrush_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014214 RID: 82452 RVA: 0x001C71B8 File Offset: 0x001C53B8
		public new static vtkBrush SafeDownCast(vtkObjectBase o)
		{
			vtkBrush vtkBrush = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBrush.vtkBrush_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBrush = (vtkBrush)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBrush.Register(null);
				}
			}
			return vtkBrush;
		}

		// Token: 0x06014215 RID: 82453
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrush_SetColor_17(HandleRef pThis, IntPtr color);

		/// <summary>
		/// Set the color of the brush with three component unsigned chars (RGB),
		/// ranging from 0 to 255.
		/// </summary>
		// Token: 0x06014216 RID: 82454 RVA: 0x001C7237 File Offset: 0x001C5437
		public void SetColor(IntPtr color)
		{
			vtkBrush.vtkBrush_SetColor_17(base.GetCppThis(), color);
		}

		// Token: 0x06014217 RID: 82455
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrush_SetColor_18(HandleRef pThis, byte r, byte g, byte b);

		/// <summary>
		/// Set the color of the brush with three component unsigned chars (RGB),
		/// ranging from 0 to 255.
		/// </summary>
		// Token: 0x06014218 RID: 82456 RVA: 0x001C7247 File Offset: 0x001C5447
		public void SetColor(byte r, byte g, byte b)
		{
			vtkBrush.vtkBrush_SetColor_18(base.GetCppThis(), r, g, b);
		}

		// Token: 0x06014219 RID: 82457
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrush_SetColor_19(HandleRef pThis, byte r, byte g, byte b, byte a);

		/// <summary>
		/// Set the color of the brush with four component unsigned chars (RGBA),
		/// ranging from 0 to 255.
		/// </summary>
		// Token: 0x0601421A RID: 82458 RVA: 0x001C7259 File Offset: 0x001C5459
		public void SetColor(byte r, byte g, byte b, byte a)
		{
			vtkBrush.vtkBrush_SetColor_19(base.GetCppThis(), r, g, b, a);
		}

		// Token: 0x0601421B RID: 82459
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrush_SetColor_20(HandleRef pThis, HandleRef color);

		/// <summary>
		/// Set the color of the brush with four component unsigned chars (RGBA),
		/// ranging from 0 to 255.
		/// </summary>
		// Token: 0x0601421C RID: 82460 RVA: 0x001C7270 File Offset: 0x001C5470
		public void SetColor(vtkColor4ub color)
		{
			vtkBrush.vtkBrush_SetColor_20(base.GetCppThis(), (color == null) ? default(HandleRef) : color.GetCppThis());
		}

		// Token: 0x0601421D RID: 82461
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrush_SetColorF_21(HandleRef pThis, IntPtr color);

		/// <summary>
		/// Set the color of the brush with three component doubles (RGB), ranging from
		/// 0.0 to 1.0.
		/// </summary>
		// Token: 0x0601421E RID: 82462 RVA: 0x001C729F File Offset: 0x001C549F
		public void SetColorF(IntPtr color)
		{
			vtkBrush.vtkBrush_SetColorF_21(base.GetCppThis(), color);
		}

		// Token: 0x0601421F RID: 82463
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrush_SetColorF_22(HandleRef pThis, double r, double g, double b);

		/// <summary>
		/// Set the color of the brush with three component doubles (RGB), ranging from
		/// 0.0 to 1.0.
		/// </summary>
		// Token: 0x06014220 RID: 82464 RVA: 0x001C72AF File Offset: 0x001C54AF
		public void SetColorF(double r, double g, double b)
		{
			vtkBrush.vtkBrush_SetColorF_22(base.GetCppThis(), r, g, b);
		}

		// Token: 0x06014221 RID: 82465
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrush_SetColorF_23(HandleRef pThis, double r, double g, double b, double a);

		/// <summary>
		/// Set the color of the brush with four component doubles (RGBA), ranging from
		/// 0.0 to 1.0.
		/// </summary>
		// Token: 0x06014222 RID: 82466 RVA: 0x001C72C1 File Offset: 0x001C54C1
		public void SetColorF(double r, double g, double b, double a)
		{
			vtkBrush.vtkBrush_SetColorF_23(base.GetCppThis(), r, g, b, a);
		}

		// Token: 0x06014223 RID: 82467
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrush_SetOpacity_24(HandleRef pThis, byte a);

		/// <summary>
		/// Set the opacity with an unsigned char, ranging from 0 (transparent) to 255
		/// (opaque).
		/// </summary>
		// Token: 0x06014224 RID: 82468 RVA: 0x001C72D5 File Offset: 0x001C54D5
		public void SetOpacity(byte a)
		{
			vtkBrush.vtkBrush_SetOpacity_24(base.GetCppThis(), a);
		}

		// Token: 0x06014225 RID: 82469
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrush_SetOpacityF_25(HandleRef pThis, double a);

		/// <summary>
		/// Set the opacity with a double, ranging from 0.0 (transparent) to 1.0
		/// (opaque).
		/// </summary>
		// Token: 0x06014226 RID: 82470 RVA: 0x001C72E5 File Offset: 0x001C54E5
		public void SetOpacityF(double a)
		{
			vtkBrush.vtkBrush_SetOpacityF_25(base.GetCppThis(), a);
		}

		// Token: 0x06014227 RID: 82471
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrush_SetTexture_26(HandleRef pThis, HandleRef image);

		/// <summary>
		/// Set the texture that will be used to fill polygons
		/// By default, no texture is set. The image will be registered with the brush
		/// (ref count is incremented)
		/// To disable the texture, set Texture to 0.
		/// </summary>
		// Token: 0x06014228 RID: 82472 RVA: 0x001C72F8 File Offset: 0x001C54F8
		public void SetTexture(vtkImageData image)
		{
			vtkBrush.vtkBrush_SetTexture_26(base.GetCppThis(), (image == null) ? default(HandleRef) : image.GetCppThis());
		}

		// Token: 0x06014229 RID: 82473
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrush_SetTextureProperties_27(HandleRef pThis, int _arg);

		/// <summary>
		/// Set properties to the texture
		/// By default, the texture is linearly stretched.
		/// The behavior is undefined when Linear and Nearest are both set
		/// The behavior is undefined when Stretch and Repeat are both set
		/// The behavior is undefined if TextureProperties is 0
		/// </summary>
		// Token: 0x0601422A RID: 82474 RVA: 0x001C7327 File Offset: 0x001C5527
		public virtual void SetTextureProperties(int _arg)
		{
			vtkBrush.vtkBrush_SetTextureProperties_27(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400175D RID: 5981
		public new const string MRFullTypeName = "Kitware.VTK.vtkBrush";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400175E RID: 5982
		public new static readonly string MRClassNameKey = "class vtkBrush";

		/// <summary>
		/// Texture properties
		/// </summary>
		// Token: 0x020007AB RID: 1963
		public enum TextureProperty
		{
			/// <summary>enum member</summary>
			// Token: 0x04001760 RID: 5984
			Linear = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001761 RID: 5985
			Nearest = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001762 RID: 5986
			Repeat = 8,
			/// <summary>enum member</summary>
			// Token: 0x04001763 RID: 5987
			Stretch = 4
		}
	}
}
