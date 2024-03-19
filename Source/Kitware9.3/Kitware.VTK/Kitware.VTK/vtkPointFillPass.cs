using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPointFillPass
	/// </summary>
	/// <remarks>
	///    Implement a post-processing fillpass
	///
	///
	/// This pass is designed to fill in rendering of sparse point sets/coulds
	/// The delegate is used once and is usually set to a vtkCameraPass or
	/// to a post-processing pass.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderPass
	/// </seealso>
	// Token: 0x020005E2 RID: 1506
	public class vtkPointFillPass : vtkDepthImageProcessingPass
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060106B3 RID: 67251 RVA: 0x0016E1A9 File Offset: 0x0016C3A9
		static vtkPointFillPass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointFillPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointFillPass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060106B4 RID: 67252 RVA: 0x0016E1D1 File Offset: 0x0016C3D1
		public vtkPointFillPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060106B5 RID: 67253
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointFillPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060106B6 RID: 67254 RVA: 0x0016E1E0 File Offset: 0x0016C3E0
		public new static vtkPointFillPass New()
		{
			vtkPointFillPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointFillPass.vtkPointFillPass_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointFillPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060106B7 RID: 67255 RVA: 0x0016E234 File Offset: 0x0016C434
		public vtkPointFillPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPointFillPass.vtkPointFillPass_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060106B8 RID: 67256 RVA: 0x0016E278 File Offset: 0x0016C478
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060106B9 RID: 67257
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkPointFillPass_GetCandidatePointRatio_01(HandleRef pThis);

		/// <summary>
		/// How far in front of a point must a neighboring point
		/// be to be used as a filler candidate.  Expressed as
		/// a multiple of the points distance from the camera.
		/// Defaults to 0.95
		/// </summary>
		// Token: 0x060106BA RID: 67258 RVA: 0x0016E284 File Offset: 0x0016C484
		public virtual float GetCandidatePointRatio()
		{
			return vtkPointFillPass.vtkPointFillPass_GetCandidatePointRatio_01(base.GetCppThis());
		}

		// Token: 0x060106BB RID: 67259
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkPointFillPass_GetMinimumCandidateAngle_02(HandleRef pThis);

		/// <summary>
		/// How large of an angle must the filler candidates
		/// span before a point will be filled. Expressed in
		/// radians. A value of pi will keep edges from growing out.
		/// Large values require more support, lower values less.
		/// </summary>
		// Token: 0x060106BC RID: 67260 RVA: 0x0016E2A4 File Offset: 0x0016C4A4
		public virtual float GetMinimumCandidateAngle()
		{
			return vtkPointFillPass.vtkPointFillPass_GetMinimumCandidateAngle_02(base.GetCppThis());
		}

		// Token: 0x060106BD RID: 67261
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointFillPass_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060106BE RID: 67262 RVA: 0x0016E2C4 File Offset: 0x0016C4C4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPointFillPass.vtkPointFillPass_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x060106BF RID: 67263
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointFillPass_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060106C0 RID: 67264 RVA: 0x0016E2E4 File Offset: 0x0016C4E4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPointFillPass.vtkPointFillPass_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060106C1 RID: 67265
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointFillPass_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060106C2 RID: 67266 RVA: 0x0016E300 File Offset: 0x0016C500
		public override int IsA(string type)
		{
			return vtkPointFillPass.vtkPointFillPass_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x060106C3 RID: 67267
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointFillPass_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060106C4 RID: 67268 RVA: 0x0016E320 File Offset: 0x0016C520
		public new static int IsTypeOf(string type)
		{
			return vtkPointFillPass.vtkPointFillPass_IsTypeOf_06(type);
		}

		// Token: 0x060106C5 RID: 67269
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointFillPass_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060106C6 RID: 67270 RVA: 0x0016E33C File Offset: 0x0016C53C
		public new vtkPointFillPass NewInstance()
		{
			vtkPointFillPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointFillPass.vtkPointFillPass_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointFillPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060106C7 RID: 67271
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointFillPass_ReleaseGraphicsResources_09(HandleRef pThis, HandleRef w);

		/// <summary>
		/// Release graphics resources and ask components to release their own
		/// resources.
		/// \pre w_exists: w!=0
		/// </summary>
		// Token: 0x060106C8 RID: 67272 RVA: 0x0016E398 File Offset: 0x0016C598
		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkPointFillPass.vtkPointFillPass_ReleaseGraphicsResources_09(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		// Token: 0x060106C9 RID: 67273
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointFillPass_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060106CA RID: 67274 RVA: 0x0016E3C8 File Offset: 0x0016C5C8
		public new static vtkPointFillPass SafeDownCast(vtkObjectBase o)
		{
			vtkPointFillPass vtkPointFillPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointFillPass.vtkPointFillPass_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointFillPass = (vtkPointFillPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointFillPass.Register(null);
				}
			}
			return vtkPointFillPass;
		}

		// Token: 0x060106CB RID: 67275
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointFillPass_SetCandidatePointRatio_11(HandleRef pThis, float _arg);

		/// <summary>
		/// How far in front of a point must a neighboring point
		/// be to be used as a filler candidate.  Expressed as
		/// a multiple of the points distance from the camera.
		/// Defaults to 0.95
		/// </summary>
		// Token: 0x060106CC RID: 67276 RVA: 0x0016E447 File Offset: 0x0016C647
		public virtual void SetCandidatePointRatio(float _arg)
		{
			vtkPointFillPass.vtkPointFillPass_SetCandidatePointRatio_11(base.GetCppThis(), _arg);
		}

		// Token: 0x060106CD RID: 67277
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointFillPass_SetMinimumCandidateAngle_12(HandleRef pThis, float _arg);

		/// <summary>
		/// How large of an angle must the filler candidates
		/// span before a point will be filled. Expressed in
		/// radians. A value of pi will keep edges from growing out.
		/// Large values require more support, lower values less.
		/// </summary>
		// Token: 0x060106CE RID: 67278 RVA: 0x0016E457 File Offset: 0x0016C657
		public virtual void SetMinimumCandidateAngle(float _arg)
		{
			vtkPointFillPass.vtkPointFillPass_SetMinimumCandidateAngle_12(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001310 RID: 4880
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointFillPass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001311 RID: 4881
		public new static readonly string MRClassNameKey = "class vtkPointFillPass";
	}
}
