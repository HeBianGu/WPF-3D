using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkEDLShading
	///
	///
	/// Implement an EDL offscreen shading.
	/// Shade the image rendered by its delegate. Two image resolutions are used
	///
	/// This pass expects an initialized depth buffer and color buffer.
	/// Initialized buffers means they have been cleared with farthest z-value and
	/// background color/gradient/transparent color.
	/// An opaque pass may have been performed right after the initialization.
	///
	/// The delegate is used once.
	///
	/// Its delegate is usually set to a vtkCameraPass or to a post-processing pass.
	///
	/// </summary>
	// Token: 0x0200058A RID: 1418
	public class vtkEDLShading : vtkDepthImageProcessingPass
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600FA5D RID: 64093 RVA: 0x0015C423 File Offset: 0x0015A623
		static vtkEDLShading()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEDLShading.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEDLShading"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600FA5E RID: 64094 RVA: 0x0015C44B File Offset: 0x0015A64B
		public vtkEDLShading(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600FA5F RID: 64095
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEDLShading_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA60 RID: 64096 RVA: 0x0015C45C File Offset: 0x0015A65C
		public new static vtkEDLShading New()
		{
			vtkEDLShading result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEDLShading.vtkEDLShading_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEDLShading)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA61 RID: 64097 RVA: 0x0015C4B0 File Offset: 0x0015A6B0
		public vtkEDLShading() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkEDLShading.vtkEDLShading_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600FA62 RID: 64098 RVA: 0x0015C4F4 File Offset: 0x0015A6F4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600FA63 RID: 64099
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEDLShading_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA64 RID: 64100 RVA: 0x0015C500 File Offset: 0x0015A700
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkEDLShading.vtkEDLShading_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600FA65 RID: 64101
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEDLShading_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA66 RID: 64102 RVA: 0x0015C520 File Offset: 0x0015A720
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkEDLShading.vtkEDLShading_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600FA67 RID: 64103
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEDLShading_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA68 RID: 64104 RVA: 0x0015C53C File Offset: 0x0015A73C
		public override int IsA(string type)
		{
			return vtkEDLShading.vtkEDLShading_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600FA69 RID: 64105
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEDLShading_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA6A RID: 64106 RVA: 0x0015C55C File Offset: 0x0015A75C
		public new static int IsTypeOf(string type)
		{
			return vtkEDLShading.vtkEDLShading_IsTypeOf_04(type);
		}

		// Token: 0x0600FA6B RID: 64107
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEDLShading_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA6C RID: 64108 RVA: 0x0015C578 File Offset: 0x0015A778
		public new vtkEDLShading NewInstance()
		{
			vtkEDLShading result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEDLShading.vtkEDLShading_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEDLShading)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600FA6D RID: 64109
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEDLShading_ReleaseGraphicsResources_07(HandleRef pThis, HandleRef w);

		/// <summary>
		/// Release graphics resources and ask components to release their own
		/// resources.
		/// \pre w_exists: w!=0
		/// </summary>
		// Token: 0x0600FA6E RID: 64110 RVA: 0x0015C5D4 File Offset: 0x0015A7D4
		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkEDLShading.vtkEDLShading_ReleaseGraphicsResources_07(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		// Token: 0x0600FA6F RID: 64111
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEDLShading_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA70 RID: 64112 RVA: 0x0015C604 File Offset: 0x0015A804
		public new static vtkEDLShading SafeDownCast(vtkObjectBase o)
		{
			vtkEDLShading vtkEDLShading = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEDLShading.vtkEDLShading_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEDLShading = (vtkEDLShading)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEDLShading.Register(null);
				}
			}
			return vtkEDLShading;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001232 RID: 4658
		public new const string MRFullTypeName = "Kitware.VTK.vtkEDLShading";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001233 RID: 4659
		public new static readonly string MRClassNameKey = "class vtkEDLShading";
	}
}
