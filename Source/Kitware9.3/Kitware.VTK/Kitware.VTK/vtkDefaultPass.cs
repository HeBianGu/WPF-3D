using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDefaultPass
	/// </summary>
	/// <remarks>
	///    Implement the basic render passes.
	///
	/// vtkDefaultPass implements the basic standard render passes of VTK.
	/// Subclasses can easily be implemented by reusing some parts of the basic
	/// implementation.
	///
	/// It implements classic Render operations as well as versions with property
	/// key checking.
	///
	/// This pass expects an initialized depth buffer and color buffer.
	/// Initialized buffers means they have been cleared with farthest z-value and
	/// background color/gradient/transparent color.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderPass
	/// </seealso>
	// Token: 0x02000581 RID: 1409
	public class vtkDefaultPass : vtkRenderPass
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F989 RID: 63881 RVA: 0x0015ACB4 File Offset: 0x00158EB4
		static vtkDefaultPass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDefaultPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDefaultPass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F98A RID: 63882 RVA: 0x0015ACDC File Offset: 0x00158EDC
		public vtkDefaultPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F98B RID: 63883
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDefaultPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F98C RID: 63884 RVA: 0x0015ACEC File Offset: 0x00158EEC
		public new static vtkDefaultPass New()
		{
			vtkDefaultPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDefaultPass.vtkDefaultPass_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDefaultPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F98D RID: 63885 RVA: 0x0015AD40 File Offset: 0x00158F40
		public vtkDefaultPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDefaultPass.vtkDefaultPass_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F98E RID: 63886 RVA: 0x0015AD84 File Offset: 0x00158F84
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F98F RID: 63887
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDefaultPass_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F990 RID: 63888 RVA: 0x0015AD90 File Offset: 0x00158F90
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDefaultPass.vtkDefaultPass_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600F991 RID: 63889
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDefaultPass_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F992 RID: 63890 RVA: 0x0015ADB0 File Offset: 0x00158FB0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDefaultPass.vtkDefaultPass_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600F993 RID: 63891
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDefaultPass_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F994 RID: 63892 RVA: 0x0015ADCC File Offset: 0x00158FCC
		public override int IsA(string type)
		{
			return vtkDefaultPass.vtkDefaultPass_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600F995 RID: 63893
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDefaultPass_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F996 RID: 63894 RVA: 0x0015ADEC File Offset: 0x00158FEC
		public new static int IsTypeOf(string type)
		{
			return vtkDefaultPass.vtkDefaultPass_IsTypeOf_04(type);
		}

		// Token: 0x0600F997 RID: 63895
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDefaultPass_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F998 RID: 63896 RVA: 0x0015AE08 File Offset: 0x00159008
		public new vtkDefaultPass NewInstance()
		{
			vtkDefaultPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDefaultPass.vtkDefaultPass_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDefaultPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F999 RID: 63897
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDefaultPass_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F99A RID: 63898 RVA: 0x0015AE64 File Offset: 0x00159064
		public new static vtkDefaultPass SafeDownCast(vtkObjectBase o)
		{
			vtkDefaultPass vtkDefaultPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDefaultPass.vtkDefaultPass_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDefaultPass = (vtkDefaultPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDefaultPass.Register(null);
				}
			}
			return vtkDefaultPass;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400121B RID: 4635
		public new const string MRFullTypeName = "Kitware.VTK.vtkDefaultPass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400121C RID: 4636
		public new static readonly string MRClassNameKey = "class vtkDefaultPass";
	}
}
