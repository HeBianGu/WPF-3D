using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenXRRenderer
	/// </summary>
	/// <remarks>
	///    OpenXR renderer
	///
	/// vtkOpenXRRenderer is a concrete implementation of the abstract class
	/// vtkVRRenderer. vtkOpenXRRenderer interfaces to the OpenXR rendering library.
	/// </remarks>
	// Token: 0x020000B0 RID: 176
	public class vtkOpenXRRenderer : vtkVRRenderer
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060026EA RID: 9962 RVA: 0x000397A3 File Offset: 0x000379A3
		static vtkOpenXRRenderer()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenXRRenderer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenXRRenderer"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060026EB RID: 9963 RVA: 0x000397CB File Offset: 0x000379CB
		public vtkOpenXRRenderer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060026EC RID: 9964
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenXRRenderer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060026ED RID: 9965 RVA: 0x000397DC File Offset: 0x000379DC
		public new static vtkOpenXRRenderer New()
		{
			vtkOpenXRRenderer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenXRRenderer.vtkOpenXRRenderer_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenXRRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060026EE RID: 9966 RVA: 0x00039830 File Offset: 0x00037A30
		public vtkOpenXRRenderer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenXRRenderer.vtkOpenXRRenderer_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060026EF RID: 9967 RVA: 0x00039874 File Offset: 0x00037A74
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060026F0 RID: 9968
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenXRRenderer_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060026F1 RID: 9969 RVA: 0x00039880 File Offset: 0x00037A80
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenXRRenderer.vtkOpenXRRenderer_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060026F2 RID: 9970
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenXRRenderer_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060026F3 RID: 9971 RVA: 0x000398A0 File Offset: 0x00037AA0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenXRRenderer.vtkOpenXRRenderer_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060026F4 RID: 9972
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenXRRenderer_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060026F5 RID: 9973 RVA: 0x000398BC File Offset: 0x00037ABC
		public override int IsA(string type)
		{
			return vtkOpenXRRenderer.vtkOpenXRRenderer_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x060026F6 RID: 9974
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenXRRenderer_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060026F7 RID: 9975 RVA: 0x000398DC File Offset: 0x00037ADC
		public new static int IsTypeOf(string type)
		{
			return vtkOpenXRRenderer.vtkOpenXRRenderer_IsTypeOf_04(type);
		}

		// Token: 0x060026F8 RID: 9976
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenXRRenderer_MakeCamera_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create a new Camera suitable for use with this type of Renderer.
		/// </summary>
		// Token: 0x060026F9 RID: 9977 RVA: 0x000398F8 File Offset: 0x00037AF8
		public override vtkCamera MakeCamera()
		{
			vtkCamera vtkCamera = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenXRRenderer.vtkOpenXRRenderer_MakeCamera_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCamera = (vtkCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCamera.Register(null);
				}
			}
			return vtkCamera;
		}

		// Token: 0x060026FA RID: 9978
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenXRRenderer_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060026FB RID: 9979 RVA: 0x00039968 File Offset: 0x00037B68
		public new vtkOpenXRRenderer NewInstance()
		{
			vtkOpenXRRenderer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenXRRenderer.vtkOpenXRRenderer_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenXRRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060026FC RID: 9980
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenXRRenderer_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060026FD RID: 9981 RVA: 0x000399C4 File Offset: 0x00037BC4
		public new static vtkOpenXRRenderer SafeDownCast(vtkObjectBase o)
		{
			vtkOpenXRRenderer vtkOpenXRRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenXRRenderer.vtkOpenXRRenderer_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenXRRenderer = (vtkOpenXRRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenXRRenderer.Register(null);
				}
			}
			return vtkOpenXRRenderer;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000549 RID: 1353
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenXRRenderer";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400054A RID: 1354
		public new static readonly string MRClassNameKey = "class vtkOpenXRRenderer";
	}
}
