using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLTextActor
	/// </summary>
	/// <remarks>
	///    vtkTextActor override.
	/// </remarks>
	// Token: 0x020005D1 RID: 1489
	public class vtkOpenGLTextActor : vtkTextActor
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601042B RID: 66603 RVA: 0x0016A61F File Offset: 0x0016881F
		static vtkOpenGLTextActor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLTextActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLTextActor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601042C RID: 66604 RVA: 0x0016A647 File Offset: 0x00168847
		public vtkOpenGLTextActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601042D RID: 66605
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLTextActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601042E RID: 66606 RVA: 0x0016A658 File Offset: 0x00168858
		public new static vtkOpenGLTextActor New()
		{
			vtkOpenGLTextActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLTextActor.vtkOpenGLTextActor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLTextActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601042F RID: 66607 RVA: 0x0016A6AC File Offset: 0x001688AC
		public vtkOpenGLTextActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLTextActor.vtkOpenGLTextActor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010430 RID: 66608 RVA: 0x0016A6F0 File Offset: 0x001688F0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010431 RID: 66609
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLTextActor_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010432 RID: 66610 RVA: 0x0016A6FC File Offset: 0x001688FC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLTextActor.vtkOpenGLTextActor_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06010433 RID: 66611
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLTextActor_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010434 RID: 66612 RVA: 0x0016A71C File Offset: 0x0016891C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLTextActor.vtkOpenGLTextActor_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06010435 RID: 66613
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLTextActor_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010436 RID: 66614 RVA: 0x0016A738 File Offset: 0x00168938
		public override int IsA(string type)
		{
			return vtkOpenGLTextActor.vtkOpenGLTextActor_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06010437 RID: 66615
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLTextActor_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010438 RID: 66616 RVA: 0x0016A758 File Offset: 0x00168958
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLTextActor.vtkOpenGLTextActor_IsTypeOf_04(type);
		}

		// Token: 0x06010439 RID: 66617
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLTextActor_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601043A RID: 66618 RVA: 0x0016A774 File Offset: 0x00168974
		public new vtkOpenGLTextActor NewInstance()
		{
			vtkOpenGLTextActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLTextActor.vtkOpenGLTextActor_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLTextActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601043B RID: 66619
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLTextActor_RenderOverlay_07(HandleRef pThis, HandleRef viewport);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601043C RID: 66620 RVA: 0x0016A7D0 File Offset: 0x001689D0
		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkOpenGLTextActor.vtkOpenGLTextActor_RenderOverlay_07(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0601043D RID: 66621
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLTextActor_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601043E RID: 66622 RVA: 0x0016A804 File Offset: 0x00168A04
		public new static vtkOpenGLTextActor SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLTextActor vtkOpenGLTextActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLTextActor.vtkOpenGLTextActor_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLTextActor = (vtkOpenGLTextActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLTextActor.Register(null);
				}
			}
			return vtkOpenGLTextActor;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012E9 RID: 4841
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLTextActor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012EA RID: 4842
		public new static readonly string MRClassNameKey = "class vtkOpenGLTextActor";
	}
}
