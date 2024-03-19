using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBalloonRepresentation
	/// </summary>
	/// <remarks>
	///    represent the vtkBalloonWidget
	///
	/// The vtkBalloonRepresentation is used to represent the vtkBalloonWidget.
	/// This representation is defined by two items: a text string and an image.
	/// At least one of these two items must be defined, but it is allowable to
	/// specify both, or just an image or just text. If both the text and image
	/// are specified, then methods are available for positioning the text and
	/// image with respect to each other.
	///
	/// The balloon representation consists of three parts: text, a rectangular
	/// frame behind the text, and an image placed next to the frame and sized
	/// to match the frame.
	///
	/// The size of the balloon is ultimately controlled by the text properties
	/// (i.e., font size). This representation uses a layout policy as follows.
	///
	/// If there is just text and no image, then the text properties and padding
	/// are used to control the size of the balloon.
	///
	/// If there is just an image and no text, then the ImageSize[2] member is
	/// used to control the image size. (The image will fit into this rectangle,
	/// but will not necessarily fill the whole rectangle, i.e., the image is not
	/// stretched).
	///
	/// If there is text and an image, the following approach ia used. First,
	/// based on the font size and other related properties (e.g., padding),
	/// determine the size of the frame. Second, depending on the layout of the
	/// image and text frame, control the size of the neighboring image (since the
	/// frame and image share a common edge). However, if this results in an image
	/// that is smaller than ImageSize[2], then the image size will be set to
	/// ImageSize[2] and the frame will be adjusted accordingly. The text is
	/// always placed in the center of the frame if the frame is resized.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkBalloonWidget
	/// </seealso>
	// Token: 0x020002C0 RID: 704
	public class vtkBalloonRepresentation : vtkWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007F1F RID: 32543 RVA: 0x000B664F File Offset: 0x000B484F
		static vtkBalloonRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBalloonRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBalloonRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007F20 RID: 32544 RVA: 0x000B6677 File Offset: 0x000B4877
		public vtkBalloonRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06007F21 RID: 32545
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBalloonRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06007F22 RID: 32546 RVA: 0x000B6688 File Offset: 0x000B4888
		public new static vtkBalloonRepresentation New()
		{
			vtkBalloonRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBalloonRepresentation.vtkBalloonRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBalloonRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06007F23 RID: 32547 RVA: 0x000B66DC File Offset: 0x000B48DC
		public vtkBalloonRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBalloonRepresentation.vtkBalloonRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007F24 RID: 32548 RVA: 0x000B6720 File Offset: 0x000B4920
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007F25 RID: 32549
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBalloonRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06007F26 RID: 32550 RVA: 0x000B672B File Offset: 0x000B492B
		public override void BuildRepresentation()
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06007F27 RID: 32551
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBalloonRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06007F28 RID: 32552 RVA: 0x000B673C File Offset: 0x000B493C
		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkBalloonRepresentation.vtkBalloonRepresentation_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		// Token: 0x06007F29 RID: 32553
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBalloonRepresentation_EndWidgetInteraction_03(HandleRef pThis, IntPtr e);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06007F2A RID: 32554 RVA: 0x000B675E File Offset: 0x000B495E
		public override void EndWidgetInteraction(IntPtr e)
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_EndWidgetInteraction_03(base.GetCppThis(), e);
		}

		// Token: 0x06007F2B RID: 32555
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBalloonRepresentation_GetBalloonImage_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify/retrieve the image to display in the balloon.
		/// </summary>
		// Token: 0x06007F2C RID: 32556 RVA: 0x000B6770 File Offset: 0x000B4970
		public virtual vtkImageData GetBalloonImage()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBalloonRepresentation.vtkBalloonRepresentation_GetBalloonImage_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06007F2D RID: 32557
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBalloonRepresentation_GetBalloonLayout_05(HandleRef pThis);

		/// <summary>
		/// Specify the layout of the image and text within the balloon. Note that
		/// there are reduncies in these methods, for example
		/// SetBalloonLayoutToImageLeft() results in the same effect as
		/// SetBalloonLayoutToTextRight(). If only text is specified, or only an
		/// image is specified, then it doesn't matter how the layout is specified.
		/// </summary>
		// Token: 0x06007F2E RID: 32558 RVA: 0x000B67E0 File Offset: 0x000B49E0
		public virtual int GetBalloonLayout()
		{
			return vtkBalloonRepresentation.vtkBalloonRepresentation_GetBalloonLayout_05(base.GetCppThis());
		}

		// Token: 0x06007F2F RID: 32559
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBalloonRepresentation_GetBalloonText_06(HandleRef pThis);

		/// <summary>
		/// Specify/retrieve the text to display in the balloon.
		/// </summary>
		// Token: 0x06007F30 RID: 32560 RVA: 0x000B6800 File Offset: 0x000B4A00
		public virtual string GetBalloonText()
		{
			string s = Marshal.PtrToStringAnsi(vtkBalloonRepresentation.vtkBalloonRepresentation_GetBalloonText_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06007F31 RID: 32561
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBalloonRepresentation_GetFrameProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the frame property (relevant only if text is shown).
		/// The frame lies behind the text.
		/// </summary>
		// Token: 0x06007F32 RID: 32562 RVA: 0x000B683C File Offset: 0x000B4A3C
		public virtual vtkProperty2D GetFrameProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBalloonRepresentation.vtkBalloonRepresentation_GetFrameProperty_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty2D = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty2D.Register(null);
				}
			}
			return vtkProperty2D;
		}

		// Token: 0x06007F33 RID: 32563
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBalloonRepresentation_GetImageProperty_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the image property (relevant only if an image is shown).
		/// </summary>
		// Token: 0x06007F34 RID: 32564 RVA: 0x000B68AC File Offset: 0x000B4AAC
		public virtual vtkProperty2D GetImageProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBalloonRepresentation.vtkBalloonRepresentation_GetImageProperty_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty2D = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty2D.Register(null);
				}
			}
			return vtkProperty2D;
		}

		// Token: 0x06007F35 RID: 32565
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBalloonRepresentation_GetImageSize_09(HandleRef pThis);

		/// <summary>
		/// Specify the minimum size for the image. Note that this is a bounding
		/// rectangle, the image will fit inside of it. However, if the balloon
		/// consists of text plus an image, then the image may be bigger than
		/// ImageSize[2] to fit into the balloon frame.
		/// </summary>
		// Token: 0x06007F36 RID: 32566 RVA: 0x000B691C File Offset: 0x000B4B1C
		public virtual int[] GetImageSize()
		{
			IntPtr intPtr = vtkBalloonRepresentation.vtkBalloonRepresentation_GetImageSize_09(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06007F37 RID: 32567
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBalloonRepresentation_GetImageSize_10(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Specify the minimum size for the image. Note that this is a bounding
		/// rectangle, the image will fit inside of it. However, if the balloon
		/// consists of text plus an image, then the image may be bigger than
		/// ImageSize[2] to fit into the balloon frame.
		/// </summary>
		// Token: 0x06007F38 RID: 32568 RVA: 0x000B6964 File Offset: 0x000B4B64
		public virtual void GetImageSize(ref int _arg1, ref int _arg2)
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_GetImageSize_10(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06007F39 RID: 32569
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBalloonRepresentation_GetImageSize_11(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the minimum size for the image. Note that this is a bounding
		/// rectangle, the image will fit inside of it. However, if the balloon
		/// consists of text plus an image, then the image may be bigger than
		/// ImageSize[2] to fit into the balloon frame.
		/// </summary>
		// Token: 0x06007F3A RID: 32570 RVA: 0x000B6975 File Offset: 0x000B4B75
		public virtual void GetImageSize(IntPtr _arg)
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_GetImageSize_11(base.GetCppThis(), _arg);
		}

		// Token: 0x06007F3B RID: 32571
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBalloonRepresentation_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06007F3C RID: 32572 RVA: 0x000B6988 File Offset: 0x000B4B88
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBalloonRepresentation.vtkBalloonRepresentation_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x06007F3D RID: 32573
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBalloonRepresentation_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06007F3E RID: 32574 RVA: 0x000B69A8 File Offset: 0x000B4BA8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBalloonRepresentation.vtkBalloonRepresentation_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x06007F3F RID: 32575
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBalloonRepresentation_GetOffset_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the offset from the mouse pointer from which to place the
		/// balloon. The representation will try and honor this offset unless there
		/// is a collision with the side of the renderer, in which case the balloon
		/// will be repositioned to lie within the rendering window.
		/// </summary>
		// Token: 0x06007F40 RID: 32576 RVA: 0x000B69C4 File Offset: 0x000B4BC4
		public virtual int[] GetOffset()
		{
			IntPtr intPtr = vtkBalloonRepresentation.vtkBalloonRepresentation_GetOffset_14(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06007F41 RID: 32577
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBalloonRepresentation_GetOffset_15(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Set/Get the offset from the mouse pointer from which to place the
		/// balloon. The representation will try and honor this offset unless there
		/// is a collision with the side of the renderer, in which case the balloon
		/// will be repositioned to lie within the rendering window.
		/// </summary>
		// Token: 0x06007F42 RID: 32578 RVA: 0x000B6A0C File Offset: 0x000B4C0C
		public virtual void GetOffset(ref int _arg1, ref int _arg2)
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_GetOffset_15(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06007F43 RID: 32579
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBalloonRepresentation_GetOffset_16(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the offset from the mouse pointer from which to place the
		/// balloon. The representation will try and honor this offset unless there
		/// is a collision with the side of the renderer, in which case the balloon
		/// will be repositioned to lie within the rendering window.
		/// </summary>
		// Token: 0x06007F44 RID: 32580 RVA: 0x000B6A1D File Offset: 0x000B4C1D
		public virtual void GetOffset(IntPtr _arg)
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_GetOffset_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06007F45 RID: 32581
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBalloonRepresentation_GetPadding_17(HandleRef pThis);

		/// <summary>
		/// Set/Get the padding (in pixels) that is used between the text and the
		/// frame.
		/// </summary>
		// Token: 0x06007F46 RID: 32582 RVA: 0x000B6A30 File Offset: 0x000B4C30
		public virtual int GetPadding()
		{
			return vtkBalloonRepresentation.vtkBalloonRepresentation_GetPadding_17(base.GetCppThis());
		}

		// Token: 0x06007F47 RID: 32583
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBalloonRepresentation_GetPaddingMaxValue_18(HandleRef pThis);

		/// <summary>
		/// Set/Get the padding (in pixels) that is used between the text and the
		/// frame.
		/// </summary>
		// Token: 0x06007F48 RID: 32584 RVA: 0x000B6A50 File Offset: 0x000B4C50
		public virtual int GetPaddingMaxValue()
		{
			return vtkBalloonRepresentation.vtkBalloonRepresentation_GetPaddingMaxValue_18(base.GetCppThis());
		}

		// Token: 0x06007F49 RID: 32585
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBalloonRepresentation_GetPaddingMinValue_19(HandleRef pThis);

		/// <summary>
		/// Set/Get the padding (in pixels) that is used between the text and the
		/// frame.
		/// </summary>
		// Token: 0x06007F4A RID: 32586 RVA: 0x000B6A70 File Offset: 0x000B4C70
		public virtual int GetPaddingMinValue()
		{
			return vtkBalloonRepresentation.vtkBalloonRepresentation_GetPaddingMinValue_19(base.GetCppThis());
		}

		// Token: 0x06007F4B RID: 32587
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBalloonRepresentation_GetTextProperty_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the text property (relevant only if text is shown).
		/// </summary>
		// Token: 0x06007F4C RID: 32588 RVA: 0x000B6A90 File Offset: 0x000B4C90
		public virtual vtkTextProperty GetTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBalloonRepresentation.vtkBalloonRepresentation_GetTextProperty_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		// Token: 0x06007F4D RID: 32589
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBalloonRepresentation_IsA_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06007F4E RID: 32590 RVA: 0x000B6B00 File Offset: 0x000B4D00
		public override int IsA(string type)
		{
			return vtkBalloonRepresentation.vtkBalloonRepresentation_IsA_21(base.GetCppThis(), type);
		}

		// Token: 0x06007F4F RID: 32591
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBalloonRepresentation_IsTypeOf_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06007F50 RID: 32592 RVA: 0x000B6B20 File Offset: 0x000B4D20
		public new static int IsTypeOf(string type)
		{
			return vtkBalloonRepresentation.vtkBalloonRepresentation_IsTypeOf_22(type);
		}

		// Token: 0x06007F51 RID: 32593
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBalloonRepresentation_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06007F52 RID: 32594 RVA: 0x000B6B3C File Offset: 0x000B4D3C
		public new vtkBalloonRepresentation NewInstance()
		{
			vtkBalloonRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBalloonRepresentation.vtkBalloonRepresentation_NewInstance_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBalloonRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007F53 RID: 32595
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBalloonRepresentation_ReleaseGraphicsResources_25(HandleRef pThis, HandleRef w);

		/// <summary>
		/// Methods required by vtkProp superclass.
		/// </summary>
		// Token: 0x06007F54 RID: 32596 RVA: 0x000B6B98 File Offset: 0x000B4D98
		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_ReleaseGraphicsResources_25(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		// Token: 0x06007F55 RID: 32597
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBalloonRepresentation_RenderOverlay_26(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods required by vtkProp superclass.
		/// </summary>
		// Token: 0x06007F56 RID: 32598 RVA: 0x000B6BC8 File Offset: 0x000B4DC8
		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkBalloonRepresentation.vtkBalloonRepresentation_RenderOverlay_26(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06007F57 RID: 32599
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBalloonRepresentation_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06007F58 RID: 32600 RVA: 0x000B6BFC File Offset: 0x000B4DFC
		public new static vtkBalloonRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkBalloonRepresentation vtkBalloonRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBalloonRepresentation.vtkBalloonRepresentation_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBalloonRepresentation = (vtkBalloonRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBalloonRepresentation.Register(null);
				}
			}
			return vtkBalloonRepresentation;
		}

		// Token: 0x06007F59 RID: 32601
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBalloonRepresentation_SetBalloonImage_28(HandleRef pThis, HandleRef img);

		/// <summary>
		/// Specify/retrieve the image to display in the balloon.
		/// </summary>
		// Token: 0x06007F5A RID: 32602 RVA: 0x000B6C7C File Offset: 0x000B4E7C
		public virtual void SetBalloonImage(vtkImageData img)
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetBalloonImage_28(base.GetCppThis(), (img == null) ? default(HandleRef) : img.GetCppThis());
		}

		// Token: 0x06007F5B RID: 32603
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBalloonRepresentation_SetBalloonLayout_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the layout of the image and text within the balloon. Note that
		/// there are reduncies in these methods, for example
		/// SetBalloonLayoutToImageLeft() results in the same effect as
		/// SetBalloonLayoutToTextRight(). If only text is specified, or only an
		/// image is specified, then it doesn't matter how the layout is specified.
		/// </summary>
		// Token: 0x06007F5C RID: 32604 RVA: 0x000B6CAB File Offset: 0x000B4EAB
		public virtual void SetBalloonLayout(int _arg)
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetBalloonLayout_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06007F5D RID: 32605
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBalloonRepresentation_SetBalloonLayoutToImageBottom_30(HandleRef pThis);

		/// <summary>
		/// Specify the layout of the image and text within the balloon. Note that
		/// there are reduncies in these methods, for example
		/// SetBalloonLayoutToImageLeft() results in the same effect as
		/// SetBalloonLayoutToTextRight(). If only text is specified, or only an
		/// image is specified, then it doesn't matter how the layout is specified.
		/// </summary>
		// Token: 0x06007F5E RID: 32606 RVA: 0x000B6CBB File Offset: 0x000B4EBB
		public void SetBalloonLayoutToImageBottom()
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetBalloonLayoutToImageBottom_30(base.GetCppThis());
		}

		// Token: 0x06007F5F RID: 32607
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBalloonRepresentation_SetBalloonLayoutToImageLeft_31(HandleRef pThis);

		/// <summary>
		/// Specify the layout of the image and text within the balloon. Note that
		/// there are reduncies in these methods, for example
		/// SetBalloonLayoutToImageLeft() results in the same effect as
		/// SetBalloonLayoutToTextRight(). If only text is specified, or only an
		/// image is specified, then it doesn't matter how the layout is specified.
		/// </summary>
		// Token: 0x06007F60 RID: 32608 RVA: 0x000B6CCA File Offset: 0x000B4ECA
		public void SetBalloonLayoutToImageLeft()
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetBalloonLayoutToImageLeft_31(base.GetCppThis());
		}

		// Token: 0x06007F61 RID: 32609
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBalloonRepresentation_SetBalloonLayoutToImageRight_32(HandleRef pThis);

		/// <summary>
		/// Specify the layout of the image and text within the balloon. Note that
		/// there are reduncies in these methods, for example
		/// SetBalloonLayoutToImageLeft() results in the same effect as
		/// SetBalloonLayoutToTextRight(). If only text is specified, or only an
		/// image is specified, then it doesn't matter how the layout is specified.
		/// </summary>
		// Token: 0x06007F62 RID: 32610 RVA: 0x000B6CD9 File Offset: 0x000B4ED9
		public void SetBalloonLayoutToImageRight()
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetBalloonLayoutToImageRight_32(base.GetCppThis());
		}

		// Token: 0x06007F63 RID: 32611
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBalloonRepresentation_SetBalloonLayoutToImageTop_33(HandleRef pThis);

		/// <summary>
		/// Specify the layout of the image and text within the balloon. Note that
		/// there are reduncies in these methods, for example
		/// SetBalloonLayoutToImageLeft() results in the same effect as
		/// SetBalloonLayoutToTextRight(). If only text is specified, or only an
		/// image is specified, then it doesn't matter how the layout is specified.
		/// </summary>
		// Token: 0x06007F64 RID: 32612 RVA: 0x000B6CE8 File Offset: 0x000B4EE8
		public void SetBalloonLayoutToImageTop()
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetBalloonLayoutToImageTop_33(base.GetCppThis());
		}

		// Token: 0x06007F65 RID: 32613
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBalloonRepresentation_SetBalloonLayoutToTextBottom_34(HandleRef pThis);

		/// <summary>
		/// Specify the layout of the image and text within the balloon. Note that
		/// there are reduncies in these methods, for example
		/// SetBalloonLayoutToImageLeft() results in the same effect as
		/// SetBalloonLayoutToTextRight(). If only text is specified, or only an
		/// image is specified, then it doesn't matter how the layout is specified.
		/// </summary>
		// Token: 0x06007F66 RID: 32614 RVA: 0x000B6CF7 File Offset: 0x000B4EF7
		public void SetBalloonLayoutToTextBottom()
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetBalloonLayoutToTextBottom_34(base.GetCppThis());
		}

		// Token: 0x06007F67 RID: 32615
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBalloonRepresentation_SetBalloonLayoutToTextLeft_35(HandleRef pThis);

		/// <summary>
		/// Specify the layout of the image and text within the balloon. Note that
		/// there are reduncies in these methods, for example
		/// SetBalloonLayoutToImageLeft() results in the same effect as
		/// SetBalloonLayoutToTextRight(). If only text is specified, or only an
		/// image is specified, then it doesn't matter how the layout is specified.
		/// </summary>
		// Token: 0x06007F68 RID: 32616 RVA: 0x000B6D06 File Offset: 0x000B4F06
		public void SetBalloonLayoutToTextLeft()
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetBalloonLayoutToTextLeft_35(base.GetCppThis());
		}

		// Token: 0x06007F69 RID: 32617
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBalloonRepresentation_SetBalloonLayoutToTextRight_36(HandleRef pThis);

		/// <summary>
		/// Specify the layout of the image and text within the balloon. Note that
		/// there are reduncies in these methods, for example
		/// SetBalloonLayoutToImageLeft() results in the same effect as
		/// SetBalloonLayoutToTextRight(). If only text is specified, or only an
		/// image is specified, then it doesn't matter how the layout is specified.
		/// </summary>
		// Token: 0x06007F6A RID: 32618 RVA: 0x000B6D15 File Offset: 0x000B4F15
		public void SetBalloonLayoutToTextRight()
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetBalloonLayoutToTextRight_36(base.GetCppThis());
		}

		// Token: 0x06007F6B RID: 32619
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBalloonRepresentation_SetBalloonLayoutToTextTop_37(HandleRef pThis);

		/// <summary>
		/// Specify the layout of the image and text within the balloon. Note that
		/// there are reduncies in these methods, for example
		/// SetBalloonLayoutToImageLeft() results in the same effect as
		/// SetBalloonLayoutToTextRight(). If only text is specified, or only an
		/// image is specified, then it doesn't matter how the layout is specified.
		/// </summary>
		// Token: 0x06007F6C RID: 32620 RVA: 0x000B6D24 File Offset: 0x000B4F24
		public void SetBalloonLayoutToTextTop()
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetBalloonLayoutToTextTop_37(base.GetCppThis());
		}

		// Token: 0x06007F6D RID: 32621
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBalloonRepresentation_SetBalloonText_38(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify/retrieve the text to display in the balloon.
		/// </summary>
		// Token: 0x06007F6E RID: 32622 RVA: 0x000B6D33 File Offset: 0x000B4F33
		public virtual void SetBalloonText(string _arg)
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetBalloonText_38(base.GetCppThis(), _arg);
		}

		// Token: 0x06007F6F RID: 32623
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBalloonRepresentation_SetFrameProperty_39(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Set/get the frame property (relevant only if text is shown).
		/// The frame lies behind the text.
		/// </summary>
		// Token: 0x06007F70 RID: 32624 RVA: 0x000B6D44 File Offset: 0x000B4F44
		public virtual void SetFrameProperty(vtkProperty2D p)
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetFrameProperty_39(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x06007F71 RID: 32625
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBalloonRepresentation_SetImageProperty_40(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Set/get the image property (relevant only if an image is shown).
		/// </summary>
		// Token: 0x06007F72 RID: 32626 RVA: 0x000B6D74 File Offset: 0x000B4F74
		public virtual void SetImageProperty(vtkProperty2D p)
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetImageProperty_40(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x06007F73 RID: 32627
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBalloonRepresentation_SetImageSize_41(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Specify the minimum size for the image. Note that this is a bounding
		/// rectangle, the image will fit inside of it. However, if the balloon
		/// consists of text plus an image, then the image may be bigger than
		/// ImageSize[2] to fit into the balloon frame.
		/// </summary>
		// Token: 0x06007F74 RID: 32628 RVA: 0x000B6DA3 File Offset: 0x000B4FA3
		public virtual void SetImageSize(int _arg1, int _arg2)
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetImageSize_41(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06007F75 RID: 32629
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBalloonRepresentation_SetImageSize_42(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the minimum size for the image. Note that this is a bounding
		/// rectangle, the image will fit inside of it. However, if the balloon
		/// consists of text plus an image, then the image may be bigger than
		/// ImageSize[2] to fit into the balloon frame.
		/// </summary>
		// Token: 0x06007F76 RID: 32630 RVA: 0x000B6DB4 File Offset: 0x000B4FB4
		public void SetImageSize(IntPtr _arg)
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetImageSize_42(base.GetCppThis(), _arg);
		}

		// Token: 0x06007F77 RID: 32631
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBalloonRepresentation_SetOffset_43(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Set/Get the offset from the mouse pointer from which to place the
		/// balloon. The representation will try and honor this offset unless there
		/// is a collision with the side of the renderer, in which case the balloon
		/// will be repositioned to lie within the rendering window.
		/// </summary>
		// Token: 0x06007F78 RID: 32632 RVA: 0x000B6DC4 File Offset: 0x000B4FC4
		public virtual void SetOffset(int _arg1, int _arg2)
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetOffset_43(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06007F79 RID: 32633
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBalloonRepresentation_SetOffset_44(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the offset from the mouse pointer from which to place the
		/// balloon. The representation will try and honor this offset unless there
		/// is a collision with the side of the renderer, in which case the balloon
		/// will be repositioned to lie within the rendering window.
		/// </summary>
		// Token: 0x06007F7A RID: 32634 RVA: 0x000B6DD5 File Offset: 0x000B4FD5
		public void SetOffset(IntPtr _arg)
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetOffset_44(base.GetCppThis(), _arg);
		}

		// Token: 0x06007F7B RID: 32635
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBalloonRepresentation_SetPadding_45(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the padding (in pixels) that is used between the text and the
		/// frame.
		/// </summary>
		// Token: 0x06007F7C RID: 32636 RVA: 0x000B6DE5 File Offset: 0x000B4FE5
		public virtual void SetPadding(int _arg)
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetPadding_45(base.GetCppThis(), _arg);
		}

		// Token: 0x06007F7D RID: 32637
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBalloonRepresentation_SetTextProperty_46(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Set/get the text property (relevant only if text is shown).
		/// </summary>
		// Token: 0x06007F7E RID: 32638 RVA: 0x000B6DF8 File Offset: 0x000B4FF8
		public virtual void SetTextProperty(vtkTextProperty p)
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetTextProperty_46(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x06007F7F RID: 32639
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBalloonRepresentation_StartWidgetInteraction_47(HandleRef pThis, IntPtr e);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06007F80 RID: 32640 RVA: 0x000B6E27 File Offset: 0x000B5027
		public override void StartWidgetInteraction(IntPtr e)
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_StartWidgetInteraction_47(base.GetCppThis(), e);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000ABD RID: 2749
		public new const string MRFullTypeName = "Kitware.VTK.vtkBalloonRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000ABE RID: 2750
		public new static readonly string MRClassNameKey = "class vtkBalloonRepresentation";

		/// <summary>
		/// Set/get the image property (relevant only if an image is shown).
		/// </summary>
		// Token: 0x020002C1 RID: 705
		public enum ImageBottom_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000AC0 RID: 2752
			ImageBottom = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000AC1 RID: 2753
			ImageLeft = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000AC2 RID: 2754
			ImageRight,
			/// <summary>enum member</summary>
			// Token: 0x04000AC3 RID: 2755
			ImageTop = 3
		}

		/// <summary>
		/// State is either outside, or inside (on the text portion of the image).
		/// </summary>
		// Token: 0x020002C2 RID: 706
		public enum InteractionStateType
		{
			/// <summary>enum member</summary>
			// Token: 0x04000AC5 RID: 2757
			OnImage = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000AC6 RID: 2758
			OnText = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000AC7 RID: 2759
			Outside = 0
		}
	}
}
