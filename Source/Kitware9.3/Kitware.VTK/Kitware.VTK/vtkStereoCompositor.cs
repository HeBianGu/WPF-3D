using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkStereoCompositor
	/// </summary>
	/// <remarks>
	///  helper class to generate composited stereo images.
	///
	/// vtkStereoCompositor is used by vtkRenderWindow to composite left and right
	/// eye rendering results into a single color buffer.
	///
	/// Note that all methods on vtkStereoCompositor take in pointers to the left and
	/// right rendering results and generate the result in the buffer passed for the
	/// left eye.
	/// </remarks>
	// Token: 0x02000800 RID: 2048
	public class vtkStereoCompositor : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060150B5 RID: 86197 RVA: 0x001DC67F File Offset: 0x001DA87F
		static vtkStereoCompositor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStereoCompositor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStereoCompositor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060150B6 RID: 86198 RVA: 0x001DC6A7 File Offset: 0x001DA8A7
		public vtkStereoCompositor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060150B7 RID: 86199
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStereoCompositor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060150B8 RID: 86200 RVA: 0x001DC6B8 File Offset: 0x001DA8B8
		public new static vtkStereoCompositor New()
		{
			vtkStereoCompositor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStereoCompositor.vtkStereoCompositor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStereoCompositor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060150B9 RID: 86201 RVA: 0x001DC70C File Offset: 0x001DA90C
		public vtkStereoCompositor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStereoCompositor.vtkStereoCompositor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060150BA RID: 86202 RVA: 0x001DC750 File Offset: 0x001DA950
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060150BB RID: 86203
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStereoCompositor_Anaglyph_01(HandleRef pThis, HandleRef rgbLeftNResult, HandleRef rgbRight, float colorSaturation, IntPtr colorMask);

		/// <summary>
		/// Methods for compositing left and right eye images based on various
		/// supported modes. See vtkRenderWindow::SetStereoType for explanation of each
		/// of these modes. Note that all these methods generate the result in the
		/// buffer passed for the left eye.
		/// </summary>
		// Token: 0x060150BC RID: 86204 RVA: 0x001DC75C File Offset: 0x001DA95C
		public bool Anaglyph(vtkUnsignedCharArray rgbLeftNResult, vtkUnsignedCharArray rgbRight, float colorSaturation, IntPtr colorMask)
		{
			return vtkStereoCompositor.vtkStereoCompositor_Anaglyph_01(base.GetCppThis(), (rgbLeftNResult == null) ? default(HandleRef) : rgbLeftNResult.GetCppThis(), (rgbRight == null) ? default(HandleRef) : rgbRight.GetCppThis(), colorSaturation, colorMask) != 0;
		}

		// Token: 0x060150BD RID: 86205
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStereoCompositor_Checkerboard_02(HandleRef pThis, HandleRef rgbLeftNResult, HandleRef rgbRight, IntPtr size);

		/// <summary>
		/// Methods for compositing left and right eye images based on various
		/// supported modes. See vtkRenderWindow::SetStereoType for explanation of each
		/// of these modes. Note that all these methods generate the result in the
		/// buffer passed for the left eye.
		/// </summary>
		// Token: 0x060150BE RID: 86206 RVA: 0x001DC7B0 File Offset: 0x001DA9B0
		public bool Checkerboard(vtkUnsignedCharArray rgbLeftNResult, vtkUnsignedCharArray rgbRight, IntPtr size)
		{
			return vtkStereoCompositor.vtkStereoCompositor_Checkerboard_02(base.GetCppThis(), (rgbLeftNResult == null) ? default(HandleRef) : rgbLeftNResult.GetCppThis(), (rgbRight == null) ? default(HandleRef) : rgbRight.GetCppThis(), size) != 0;
		}

		// Token: 0x060150BF RID: 86207
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStereoCompositor_Dresden_03(HandleRef pThis, HandleRef rgbLeftNResult, HandleRef rgbRight, IntPtr size);

		/// <summary>
		/// Methods for compositing left and right eye images based on various
		/// supported modes. See vtkRenderWindow::SetStereoType for explanation of each
		/// of these modes. Note that all these methods generate the result in the
		/// buffer passed for the left eye.
		/// </summary>
		// Token: 0x060150C0 RID: 86208 RVA: 0x001DC804 File Offset: 0x001DAA04
		public bool Dresden(vtkUnsignedCharArray rgbLeftNResult, vtkUnsignedCharArray rgbRight, IntPtr size)
		{
			return vtkStereoCompositor.vtkStereoCompositor_Dresden_03(base.GetCppThis(), (rgbLeftNResult == null) ? default(HandleRef) : rgbLeftNResult.GetCppThis(), (rgbRight == null) ? default(HandleRef) : rgbRight.GetCppThis(), size) != 0;
		}

		// Token: 0x060150C1 RID: 86209
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStereoCompositor_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060150C2 RID: 86210 RVA: 0x001DC858 File Offset: 0x001DAA58
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStereoCompositor.vtkStereoCompositor_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x060150C3 RID: 86211
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStereoCompositor_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060150C4 RID: 86212 RVA: 0x001DC878 File Offset: 0x001DAA78
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStereoCompositor.vtkStereoCompositor_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x060150C5 RID: 86213
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStereoCompositor_Interlaced_06(HandleRef pThis, HandleRef rgbLeftNResult, HandleRef rgbRight, IntPtr size);

		/// <summary>
		/// Methods for compositing left and right eye images based on various
		/// supported modes. See vtkRenderWindow::SetStereoType for explanation of each
		/// of these modes. Note that all these methods generate the result in the
		/// buffer passed for the left eye.
		/// </summary>
		// Token: 0x060150C6 RID: 86214 RVA: 0x001DC894 File Offset: 0x001DAA94
		public bool Interlaced(vtkUnsignedCharArray rgbLeftNResult, vtkUnsignedCharArray rgbRight, IntPtr size)
		{
			return vtkStereoCompositor.vtkStereoCompositor_Interlaced_06(base.GetCppThis(), (rgbLeftNResult == null) ? default(HandleRef) : rgbLeftNResult.GetCppThis(), (rgbRight == null) ? default(HandleRef) : rgbRight.GetCppThis(), size) != 0;
		}

		// Token: 0x060150C7 RID: 86215
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStereoCompositor_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060150C8 RID: 86216 RVA: 0x001DC8E8 File Offset: 0x001DAAE8
		public override int IsA(string type)
		{
			return vtkStereoCompositor.vtkStereoCompositor_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x060150C9 RID: 86217
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStereoCompositor_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060150CA RID: 86218 RVA: 0x001DC908 File Offset: 0x001DAB08
		public new static int IsTypeOf(string type)
		{
			return vtkStereoCompositor.vtkStereoCompositor_IsTypeOf_08(type);
		}

		// Token: 0x060150CB RID: 86219
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStereoCompositor_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060150CC RID: 86220 RVA: 0x001DC924 File Offset: 0x001DAB24
		public new vtkStereoCompositor NewInstance()
		{
			vtkStereoCompositor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStereoCompositor.vtkStereoCompositor_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStereoCompositor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060150CD RID: 86221
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStereoCompositor_RedBlue_11(HandleRef pThis, HandleRef rgbLeftNResult, HandleRef rgbRight);

		/// <summary>
		/// Methods for compositing left and right eye images based on various
		/// supported modes. See vtkRenderWindow::SetStereoType for explanation of each
		/// of these modes. Note that all these methods generate the result in the
		/// buffer passed for the left eye.
		/// </summary>
		// Token: 0x060150CE RID: 86222 RVA: 0x001DC980 File Offset: 0x001DAB80
		public bool RedBlue(vtkUnsignedCharArray rgbLeftNResult, vtkUnsignedCharArray rgbRight)
		{
			return vtkStereoCompositor.vtkStereoCompositor_RedBlue_11(base.GetCppThis(), (rgbLeftNResult == null) ? default(HandleRef) : rgbLeftNResult.GetCppThis(), (rgbRight == null) ? default(HandleRef) : rgbRight.GetCppThis()) != 0;
		}

		// Token: 0x060150CF RID: 86223
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStereoCompositor_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060150D0 RID: 86224 RVA: 0x001DC9D0 File Offset: 0x001DABD0
		public new static vtkStereoCompositor SafeDownCast(vtkObjectBase o)
		{
			vtkStereoCompositor vtkStereoCompositor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStereoCompositor.vtkStereoCompositor_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStereoCompositor = (vtkStereoCompositor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStereoCompositor.Register(null);
				}
			}
			return vtkStereoCompositor;
		}

		// Token: 0x060150D1 RID: 86225
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStereoCompositor_SplitViewportHorizontal_13(HandleRef pThis, HandleRef rgbLeftNResult, HandleRef rgbRight, IntPtr size);

		/// <summary>
		/// Methods for compositing left and right eye images based on various
		/// supported modes. See vtkRenderWindow::SetStereoType for explanation of each
		/// of these modes. Note that all these methods generate the result in the
		/// buffer passed for the left eye.
		/// </summary>
		// Token: 0x060150D2 RID: 86226 RVA: 0x001DCA50 File Offset: 0x001DAC50
		public bool SplitViewportHorizontal(vtkUnsignedCharArray rgbLeftNResult, vtkUnsignedCharArray rgbRight, IntPtr size)
		{
			return vtkStereoCompositor.vtkStereoCompositor_SplitViewportHorizontal_13(base.GetCppThis(), (rgbLeftNResult == null) ? default(HandleRef) : rgbLeftNResult.GetCppThis(), (rgbRight == null) ? default(HandleRef) : rgbRight.GetCppThis(), size) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001844 RID: 6212
		public new const string MRFullTypeName = "Kitware.VTK.vtkStereoCompositor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001845 RID: 6213
		public new static readonly string MRClassNameKey = "class vtkStereoCompositor";
	}
}
