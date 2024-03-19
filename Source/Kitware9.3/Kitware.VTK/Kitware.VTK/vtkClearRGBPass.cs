using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkClearRGBPass
	/// </summary>
	/// <remarks>
	///    Paint in the color buffer.
	///
	/// Clear the color buffer to the specified color.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkValuePasses
	/// </seealso>
	// Token: 0x0200057D RID: 1405
	public class vtkClearRGBPass : vtkRenderPass
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F8B5 RID: 63669 RVA: 0x00159A8B File Offset: 0x00157C8B
		static vtkClearRGBPass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkClearRGBPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkClearRGBPass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F8B6 RID: 63670 RVA: 0x00159AB3 File Offset: 0x00157CB3
		public vtkClearRGBPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F8B7 RID: 63671
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClearRGBPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F8B8 RID: 63672 RVA: 0x00159AC4 File Offset: 0x00157CC4
		public new static vtkClearRGBPass New()
		{
			vtkClearRGBPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClearRGBPass.vtkClearRGBPass_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClearRGBPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F8B9 RID: 63673 RVA: 0x00159B18 File Offset: 0x00157D18
		public vtkClearRGBPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkClearRGBPass.vtkClearRGBPass_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F8BA RID: 63674 RVA: 0x00159B5C File Offset: 0x00157D5C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F8BB RID: 63675
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClearRGBPass_GetBackground_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the background color of the rendering screen using an rgb color
		/// specification.
		/// </summary>
		// Token: 0x0600F8BC RID: 63676 RVA: 0x00159B68 File Offset: 0x00157D68
		public virtual double[] GetBackground()
		{
			IntPtr intPtr = vtkClearRGBPass.vtkClearRGBPass_GetBackground_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600F8BD RID: 63677
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClearRGBPass_GetBackground_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the background color of the rendering screen using an rgb color
		/// specification.
		/// </summary>
		// Token: 0x0600F8BE RID: 63678 RVA: 0x00159BB0 File Offset: 0x00157DB0
		public virtual void GetBackground(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkClearRGBPass.vtkClearRGBPass_GetBackground_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600F8BF RID: 63679
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClearRGBPass_GetBackground_03(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the background color of the rendering screen using an rgb color
		/// specification.
		/// </summary>
		// Token: 0x0600F8C0 RID: 63680 RVA: 0x00159BC2 File Offset: 0x00157DC2
		public virtual void GetBackground(IntPtr _arg)
		{
			vtkClearRGBPass.vtkClearRGBPass_GetBackground_03(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F8C1 RID: 63681
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkClearRGBPass_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F8C2 RID: 63682 RVA: 0x00159BD4 File Offset: 0x00157DD4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkClearRGBPass.vtkClearRGBPass_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600F8C3 RID: 63683
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkClearRGBPass_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F8C4 RID: 63684 RVA: 0x00159BF4 File Offset: 0x00157DF4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkClearRGBPass.vtkClearRGBPass_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600F8C5 RID: 63685
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClearRGBPass_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F8C6 RID: 63686 RVA: 0x00159C10 File Offset: 0x00157E10
		public override int IsA(string type)
		{
			return vtkClearRGBPass.vtkClearRGBPass_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0600F8C7 RID: 63687
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClearRGBPass_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F8C8 RID: 63688 RVA: 0x00159C30 File Offset: 0x00157E30
		public new static int IsTypeOf(string type)
		{
			return vtkClearRGBPass.vtkClearRGBPass_IsTypeOf_07(type);
		}

		// Token: 0x0600F8C9 RID: 63689
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClearRGBPass_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F8CA RID: 63690 RVA: 0x00159C4C File Offset: 0x00157E4C
		public new vtkClearRGBPass NewInstance()
		{
			vtkClearRGBPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClearRGBPass.vtkClearRGBPass_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClearRGBPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F8CB RID: 63691
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClearRGBPass_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F8CC RID: 63692 RVA: 0x00159CA8 File Offset: 0x00157EA8
		public new static vtkClearRGBPass SafeDownCast(vtkObjectBase o)
		{
			vtkClearRGBPass vtkClearRGBPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClearRGBPass.vtkClearRGBPass_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkClearRGBPass = (vtkClearRGBPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkClearRGBPass.Register(null);
				}
			}
			return vtkClearRGBPass;
		}

		// Token: 0x0600F8CD RID: 63693
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClearRGBPass_SetBackground_11(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the background color of the rendering screen using an rgb color
		/// specification.
		/// </summary>
		// Token: 0x0600F8CE RID: 63694 RVA: 0x00159D27 File Offset: 0x00157F27
		public virtual void SetBackground(double _arg1, double _arg2, double _arg3)
		{
			vtkClearRGBPass.vtkClearRGBPass_SetBackground_11(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600F8CF RID: 63695
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClearRGBPass_SetBackground_12(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the background color of the rendering screen using an rgb color
		/// specification.
		/// </summary>
		// Token: 0x0600F8D0 RID: 63696 RVA: 0x00159D39 File Offset: 0x00157F39
		public virtual void SetBackground(IntPtr _arg)
		{
			vtkClearRGBPass.vtkClearRGBPass_SetBackground_12(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001213 RID: 4627
		public new const string MRFullTypeName = "Kitware.VTK.vtkClearRGBPass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001214 RID: 4628
		public new static readonly string MRClassNameKey = "class vtkClearRGBPass";
	}
}
