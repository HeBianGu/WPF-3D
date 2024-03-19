using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDepthImageProcessingPass
	/// </summary>
	/// <remarks>
	///    Convenient class for post-processing
	/// passes. Based on vtkImageProcessingPass, but writes depth as well
	/// in a texture
	///
	/// Abstract class with some convenient methods frequently used in subclasses.
	///
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderPass vtkDepthImageProcessingPass vtkEDLShading
	/// </seealso>
	// Token: 0x02000584 RID: 1412
	public abstract class vtkDepthImageProcessingPass : vtkImageProcessingPass
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F9CB RID: 63947 RVA: 0x0015B447 File Offset: 0x00159647
		static vtkDepthImageProcessingPass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDepthImageProcessingPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDepthImageProcessingPass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F9CC RID: 63948 RVA: 0x0015B46F File Offset: 0x0015966F
		public vtkDepthImageProcessingPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F9CD RID: 63949 RVA: 0x0015B47D File Offset: 0x0015967D
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F9CE RID: 63950
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDepthImageProcessingPass_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F9CF RID: 63951 RVA: 0x0015B488 File Offset: 0x00159688
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDepthImageProcessingPass.vtkDepthImageProcessingPass_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600F9D0 RID: 63952
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDepthImageProcessingPass_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F9D1 RID: 63953 RVA: 0x0015B4A8 File Offset: 0x001596A8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDepthImageProcessingPass.vtkDepthImageProcessingPass_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600F9D2 RID: 63954
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDepthImageProcessingPass_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F9D3 RID: 63955 RVA: 0x0015B4C4 File Offset: 0x001596C4
		public override int IsA(string type)
		{
			return vtkDepthImageProcessingPass.vtkDepthImageProcessingPass_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600F9D4 RID: 63956
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDepthImageProcessingPass_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F9D5 RID: 63957 RVA: 0x0015B4E4 File Offset: 0x001596E4
		public new static int IsTypeOf(string type)
		{
			return vtkDepthImageProcessingPass.vtkDepthImageProcessingPass_IsTypeOf_04(type);
		}

		// Token: 0x0600F9D6 RID: 63958
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDepthImageProcessingPass_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F9D7 RID: 63959 RVA: 0x0015B500 File Offset: 0x00159700
		public new vtkDepthImageProcessingPass NewInstance()
		{
			vtkDepthImageProcessingPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDepthImageProcessingPass.vtkDepthImageProcessingPass_NewInstance_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDepthImageProcessingPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F9D8 RID: 63960
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDepthImageProcessingPass_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F9D9 RID: 63961 RVA: 0x0015B55C File Offset: 0x0015975C
		public new static vtkDepthImageProcessingPass SafeDownCast(vtkObjectBase o)
		{
			vtkDepthImageProcessingPass vtkDepthImageProcessingPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDepthImageProcessingPass.vtkDepthImageProcessingPass_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDepthImageProcessingPass = (vtkDepthImageProcessingPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDepthImageProcessingPass.Register(null);
				}
			}
			return vtkDepthImageProcessingPass;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001221 RID: 4641
		public new const string MRFullTypeName = "Kitware.VTK.vtkDepthImageProcessingPass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001222 RID: 4642
		public new static readonly string MRClassNameKey = "class vtkDepthImageProcessingPass";
	}
}
