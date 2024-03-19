using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVolumetricPass
	/// </summary>
	/// <remarks>
	///    Render the volumetric geometry with property key
	/// filtering.
	///
	/// vtkVolumetricPass renders the volumetric geometry of all the props that
	/// have the keys contained in vtkRenderState.
	///
	/// This pass expects an initialized depth buffer and color buffer.
	/// Initialized buffers means they have been cleared with farthest z-value and
	/// background color/gradient/transparent color.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderPass vtkDefaultPass
	/// </seealso>
	// Token: 0x020005F6 RID: 1526
	public class vtkVolumetricPass : vtkDefaultPass
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601090B RID: 67851 RVA: 0x00171F79 File Offset: 0x00170179
		static vtkVolumetricPass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVolumetricPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumetricPass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601090C RID: 67852 RVA: 0x00171FA1 File Offset: 0x001701A1
		public vtkVolumetricPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601090D RID: 67853
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumetricPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601090E RID: 67854 RVA: 0x00171FB0 File Offset: 0x001701B0
		public new static vtkVolumetricPass New()
		{
			vtkVolumetricPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumetricPass.vtkVolumetricPass_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumetricPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601090F RID: 67855 RVA: 0x00172004 File Offset: 0x00170204
		public vtkVolumetricPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVolumetricPass.vtkVolumetricPass_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010910 RID: 67856 RVA: 0x00172048 File Offset: 0x00170248
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010911 RID: 67857
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVolumetricPass_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010912 RID: 67858 RVA: 0x00172054 File Offset: 0x00170254
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVolumetricPass.vtkVolumetricPass_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06010913 RID: 67859
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVolumetricPass_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010914 RID: 67860 RVA: 0x00172074 File Offset: 0x00170274
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVolumetricPass.vtkVolumetricPass_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06010915 RID: 67861
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumetricPass_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010916 RID: 67862 RVA: 0x00172090 File Offset: 0x00170290
		public override int IsA(string type)
		{
			return vtkVolumetricPass.vtkVolumetricPass_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06010917 RID: 67863
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumetricPass_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010918 RID: 67864 RVA: 0x001720B0 File Offset: 0x001702B0
		public new static int IsTypeOf(string type)
		{
			return vtkVolumetricPass.vtkVolumetricPass_IsTypeOf_04(type);
		}

		// Token: 0x06010919 RID: 67865
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumetricPass_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601091A RID: 67866 RVA: 0x001720CC File Offset: 0x001702CC
		public new vtkVolumetricPass NewInstance()
		{
			vtkVolumetricPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumetricPass.vtkVolumetricPass_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumetricPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601091B RID: 67867
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumetricPass_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601091C RID: 67868 RVA: 0x00172128 File Offset: 0x00170328
		public new static vtkVolumetricPass SafeDownCast(vtkObjectBase o)
		{
			vtkVolumetricPass vtkVolumetricPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumetricPass.vtkVolumetricPass_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumetricPass = (vtkVolumetricPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumetricPass.Register(null);
				}
			}
			return vtkVolumetricPass;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001342 RID: 4930
		public new const string MRFullTypeName = "Kitware.VTK.vtkVolumetricPass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001343 RID: 4931
		public new static readonly string MRClassNameKey = "class vtkVolumetricPass";
	}
}
