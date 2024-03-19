using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMathTextFreeTypeTextRenderer
	/// </summary>
	/// <remarks>
	///    Default implementation of
	/// vtkTextRenderer.
	///
	///
	/// Default implementation of vtkTextRenderer using vtkFreeTypeTools and
	/// vtkMathTextUtilities.
	///
	/// @warning
	/// The MathText backend does not currently support UTF16 strings, thus
	/// UTF16 strings passed to the MathText renderer will be converted to
	/// UTF8.
	/// </remarks>
	// Token: 0x020007BF RID: 1983
	public class vtkMathTextFreeTypeTextRenderer : vtkTextRenderer
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014558 RID: 83288 RVA: 0x001CBFBD File Offset: 0x001CA1BD
		static vtkMathTextFreeTypeTextRenderer()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMathTextFreeTypeTextRenderer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMathTextFreeTypeTextRenderer"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014559 RID: 83289 RVA: 0x001CBFE5 File Offset: 0x001CA1E5
		public vtkMathTextFreeTypeTextRenderer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601455A RID: 83290
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMathTextFreeTypeTextRenderer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601455B RID: 83291 RVA: 0x001CBFF4 File Offset: 0x001CA1F4
		public new static vtkMathTextFreeTypeTextRenderer New()
		{
			vtkMathTextFreeTypeTextRenderer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMathTextFreeTypeTextRenderer.vtkMathTextFreeTypeTextRenderer_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMathTextFreeTypeTextRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601455C RID: 83292 RVA: 0x001CC048 File Offset: 0x001CA248
		public vtkMathTextFreeTypeTextRenderer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMathTextFreeTypeTextRenderer.vtkMathTextFreeTypeTextRenderer_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601455D RID: 83293 RVA: 0x001CC08C File Offset: 0x001CA28C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601455E RID: 83294
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMathTextFreeTypeTextRenderer_FreeTypeIsSupported_01(HandleRef pThis);

		/// <summary>
		/// Test for availability of various backends
		/// </summary>
		// Token: 0x0601455F RID: 83295 RVA: 0x001CC098 File Offset: 0x001CA298
		public override bool FreeTypeIsSupported()
		{
			return vtkMathTextFreeTypeTextRenderer.vtkMathTextFreeTypeTextRenderer_FreeTypeIsSupported_01(base.GetCppThis()) != 0;
		}

		// Token: 0x06014560 RID: 83296
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMathTextFreeTypeTextRenderer_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014561 RID: 83297 RVA: 0x001CC0C0 File Offset: 0x001CA2C0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMathTextFreeTypeTextRenderer.vtkMathTextFreeTypeTextRenderer_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06014562 RID: 83298
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMathTextFreeTypeTextRenderer_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014563 RID: 83299 RVA: 0x001CC0E0 File Offset: 0x001CA2E0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMathTextFreeTypeTextRenderer.vtkMathTextFreeTypeTextRenderer_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06014564 RID: 83300
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMathTextFreeTypeTextRenderer_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014565 RID: 83301 RVA: 0x001CC0FC File Offset: 0x001CA2FC
		public override int IsA(string type)
		{
			return vtkMathTextFreeTypeTextRenderer.vtkMathTextFreeTypeTextRenderer_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06014566 RID: 83302
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMathTextFreeTypeTextRenderer_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014567 RID: 83303 RVA: 0x001CC11C File Offset: 0x001CA31C
		public new static int IsTypeOf(string type)
		{
			return vtkMathTextFreeTypeTextRenderer.vtkMathTextFreeTypeTextRenderer_IsTypeOf_05(type);
		}

		// Token: 0x06014568 RID: 83304
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMathTextFreeTypeTextRenderer_MathTextIsSupported_06(HandleRef pThis);

		/// <summary>
		/// Test for availability of various backends
		/// </summary>
		// Token: 0x06014569 RID: 83305 RVA: 0x001CC138 File Offset: 0x001CA338
		public override bool MathTextIsSupported()
		{
			return vtkMathTextFreeTypeTextRenderer.vtkMathTextFreeTypeTextRenderer_MathTextIsSupported_06(base.GetCppThis()) != 0;
		}

		// Token: 0x0601456A RID: 83306
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMathTextFreeTypeTextRenderer_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601456B RID: 83307 RVA: 0x001CC160 File Offset: 0x001CA360
		public new vtkMathTextFreeTypeTextRenderer NewInstance()
		{
			vtkMathTextFreeTypeTextRenderer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMathTextFreeTypeTextRenderer.vtkMathTextFreeTypeTextRenderer_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMathTextFreeTypeTextRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601456C RID: 83308
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMathTextFreeTypeTextRenderer_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601456D RID: 83309 RVA: 0x001CC1BC File Offset: 0x001CA3BC
		public new static vtkMathTextFreeTypeTextRenderer SafeDownCast(vtkObjectBase o)
		{
			vtkMathTextFreeTypeTextRenderer vtkMathTextFreeTypeTextRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMathTextFreeTypeTextRenderer.vtkMathTextFreeTypeTextRenderer_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMathTextFreeTypeTextRenderer = (vtkMathTextFreeTypeTextRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMathTextFreeTypeTextRenderer.Register(null);
				}
			}
			return vtkMathTextFreeTypeTextRenderer;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400179C RID: 6044
		public new const string MRFullTypeName = "Kitware.VTK.vtkMathTextFreeTypeTextRenderer";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400179D RID: 6045
		public new static readonly string MRClassNameKey = "class vtkMathTextFreeTypeTextRenderer";
	}
}
