using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSimpleMotionBlurPass
	/// </summary>
	/// <remarks>
	///    Avergae frames to simulate motion blur.
	///
	/// A slow and simple approach that simply renders multiple frames
	/// and accumulates them before displaying them. As such it causes the
	/// render process to be SubFrames times slower than normal but handles
	/// all types of motion correctly as it is actually rendering all the
	/// sub frames.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderPass
	/// </seealso>
	// Token: 0x020005EF RID: 1519
	public class vtkSimpleMotionBlurPass : vtkDepthImageProcessingPass
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010859 RID: 67673 RVA: 0x00170F61 File Offset: 0x0016F161
		static vtkSimpleMotionBlurPass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSimpleMotionBlurPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSimpleMotionBlurPass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601085A RID: 67674 RVA: 0x00170F89 File Offset: 0x0016F189
		public vtkSimpleMotionBlurPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601085B RID: 67675
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimpleMotionBlurPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601085C RID: 67676 RVA: 0x00170F98 File Offset: 0x0016F198
		public new static vtkSimpleMotionBlurPass New()
		{
			vtkSimpleMotionBlurPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSimpleMotionBlurPass.vtkSimpleMotionBlurPass_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSimpleMotionBlurPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601085D RID: 67677 RVA: 0x00170FEC File Offset: 0x0016F1EC
		public vtkSimpleMotionBlurPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSimpleMotionBlurPass.vtkSimpleMotionBlurPass_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601085E RID: 67678 RVA: 0x00171030 File Offset: 0x0016F230
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601085F RID: 67679
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSimpleMotionBlurPass_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010860 RID: 67680 RVA: 0x0017103C File Offset: 0x0016F23C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSimpleMotionBlurPass.vtkSimpleMotionBlurPass_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06010861 RID: 67681
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSimpleMotionBlurPass_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010862 RID: 67682 RVA: 0x0017105C File Offset: 0x0016F25C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSimpleMotionBlurPass.vtkSimpleMotionBlurPass_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06010863 RID: 67683
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimpleMotionBlurPass_GetSubFrames_03(HandleRef pThis);

		/// <summary>
		/// Set the number of sub frames for doing motion blur.
		/// Once this is set greater than one, you will no longer see a new frame
		/// for every Render().  If you set this to five, you will need to do
		/// five Render() invocations before seeing the result. This isn't
		/// very impressive unless something is changing between the Renders.
		/// Changing this value may reset the current subframe count.
		/// </summary>
		// Token: 0x06010864 RID: 67684 RVA: 0x00171078 File Offset: 0x0016F278
		public virtual int GetSubFrames()
		{
			return vtkSimpleMotionBlurPass.vtkSimpleMotionBlurPass_GetSubFrames_03(base.GetCppThis());
		}

		// Token: 0x06010865 RID: 67685
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimpleMotionBlurPass_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010866 RID: 67686 RVA: 0x00171098 File Offset: 0x0016F298
		public override int IsA(string type)
		{
			return vtkSimpleMotionBlurPass.vtkSimpleMotionBlurPass_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06010867 RID: 67687
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimpleMotionBlurPass_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010868 RID: 67688 RVA: 0x001710B8 File Offset: 0x0016F2B8
		public new static int IsTypeOf(string type)
		{
			return vtkSimpleMotionBlurPass.vtkSimpleMotionBlurPass_IsTypeOf_05(type);
		}

		// Token: 0x06010869 RID: 67689
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimpleMotionBlurPass_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601086A RID: 67690 RVA: 0x001710D4 File Offset: 0x0016F2D4
		public new vtkSimpleMotionBlurPass NewInstance()
		{
			vtkSimpleMotionBlurPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSimpleMotionBlurPass.vtkSimpleMotionBlurPass_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSimpleMotionBlurPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601086B RID: 67691
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimpleMotionBlurPass_ReleaseGraphicsResources_08(HandleRef pThis, HandleRef w);

		/// <summary>
		/// Release graphics resources and ask components to release their own
		/// resources.
		/// \pre w_exists: w!=0
		/// </summary>
		// Token: 0x0601086C RID: 67692 RVA: 0x00171130 File Offset: 0x0016F330
		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkSimpleMotionBlurPass.vtkSimpleMotionBlurPass_ReleaseGraphicsResources_08(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		// Token: 0x0601086D RID: 67693
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimpleMotionBlurPass_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601086E RID: 67694 RVA: 0x00171160 File Offset: 0x0016F360
		public new static vtkSimpleMotionBlurPass SafeDownCast(vtkObjectBase o)
		{
			vtkSimpleMotionBlurPass vtkSimpleMotionBlurPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSimpleMotionBlurPass.vtkSimpleMotionBlurPass_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSimpleMotionBlurPass = (vtkSimpleMotionBlurPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSimpleMotionBlurPass.Register(null);
				}
			}
			return vtkSimpleMotionBlurPass;
		}

		// Token: 0x0601086F RID: 67695
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimpleMotionBlurPass_SetColorFormat_10(HandleRef pThis, int _arg);

		/// <summary>
		///  Set the format to use for the color texture
		///  vtkTextureObject::Float16 vtkTextureObject::Float32
		///  and vtkTextureObject::Fixed8 are supported. Fixed8
		///  is the default.
		/// </summary>
		// Token: 0x06010870 RID: 67696 RVA: 0x001711DF File Offset: 0x0016F3DF
		public virtual void SetColorFormat(int _arg)
		{
			vtkSimpleMotionBlurPass.vtkSimpleMotionBlurPass_SetColorFormat_10(base.GetCppThis(), _arg);
		}

		// Token: 0x06010871 RID: 67697
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimpleMotionBlurPass_SetDepthFormat_11(HandleRef pThis, int _arg);

		/// <summary>
		///  Set the format to use for the depth texture
		/// e.g. vtkTextureObject::Float32
		/// </summary>
		// Token: 0x06010872 RID: 67698 RVA: 0x001711EF File Offset: 0x0016F3EF
		public virtual void SetDepthFormat(int _arg)
		{
			vtkSimpleMotionBlurPass.vtkSimpleMotionBlurPass_SetDepthFormat_11(base.GetCppThis(), _arg);
		}

		// Token: 0x06010873 RID: 67699
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimpleMotionBlurPass_SetSubFrames_12(HandleRef pThis, int subFrames);

		/// <summary>
		/// Set the number of sub frames for doing motion blur.
		/// Once this is set greater than one, you will no longer see a new frame
		/// for every Render().  If you set this to five, you will need to do
		/// five Render() invocations before seeing the result. This isn't
		/// very impressive unless something is changing between the Renders.
		/// Changing this value may reset the current subframe count.
		/// </summary>
		// Token: 0x06010874 RID: 67700 RVA: 0x001711FF File Offset: 0x0016F3FF
		public virtual void SetSubFrames(int subFrames)
		{
			vtkSimpleMotionBlurPass.vtkSimpleMotionBlurPass_SetSubFrames_12(base.GetCppThis(), subFrames);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001330 RID: 4912
		public new const string MRFullTypeName = "Kitware.VTK.vtkSimpleMotionBlurPass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001331 RID: 4913
		public new static readonly string MRClassNameKey = "class vtkSimpleMotionBlurPass";
	}
}
