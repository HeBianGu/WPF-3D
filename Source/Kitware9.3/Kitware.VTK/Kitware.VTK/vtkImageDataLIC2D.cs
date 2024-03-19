using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageDataLIC2D
	///
	///
	///  GPU implementation of a Line Integral Convolution, a technique for
	///  imaging vector fields.
	///
	///  The input on port 0 is an vtkImageData with extents of a 2D image. It needs
	///  a vector field on point data. This filter only works on point vectors. One
	///  can use a vtkCellDataToPointData filter to convert cell vectors to point
	///  vectors.
	///
	///  Port 1 is a special port for customized noise input. It is an optional port.
	///  If noise input is not specified, then the filter using vtkImageNoiseSource to
	///  generate a 128x128 noise texture.
	///
	/// </summary>
	/// <seealso>
	///
	///  vtkSurfaceLICPainter vtkLineIntegralConvolution2D
	/// </seealso>
	// Token: 0x02000109 RID: 265
	public class vtkImageDataLIC2D : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003648 RID: 13896 RVA: 0x0004F39B File Offset: 0x0004D59B
		static vtkImageDataLIC2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageDataLIC2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageDataLIC2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003649 RID: 13897 RVA: 0x0004F3C3 File Offset: 0x0004D5C3
		public vtkImageDataLIC2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600364A RID: 13898
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDataLIC2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600364B RID: 13899 RVA: 0x0004F3D4 File Offset: 0x0004D5D4
		public new static vtkImageDataLIC2D New()
		{
			vtkImageDataLIC2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDataLIC2D.vtkImageDataLIC2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDataLIC2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600364C RID: 13900 RVA: 0x0004F428 File Offset: 0x0004D628
		public vtkImageDataLIC2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageDataLIC2D.vtkImageDataLIC2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600364D RID: 13901 RVA: 0x0004F46C File Offset: 0x0004D66C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600364E RID: 13902
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDataLIC2D_GetContext_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the context. Context must be a vtkOpenGLRenderWindow.
		/// This does not increase the reference count of the
		/// context to avoid reference loops.
		/// SetContext() may raise an error if the OpenGL context does not support the
		/// required OpenGL extensions. Return 0 upon failure and 1 upon success.
		/// </summary>
		// Token: 0x0600364F RID: 13903 RVA: 0x0004F478 File Offset: 0x0004D678
		public vtkRenderWindow GetContext()
		{
			vtkRenderWindow vtkRenderWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDataLIC2D.vtkImageDataLIC2D_GetContext_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindow = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindow.Register(null);
				}
			}
			return vtkRenderWindow;
		}

		// Token: 0x06003650 RID: 13904
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDataLIC2D_GetMagnification_02(HandleRef pThis);

		/// <summary>
		/// The magnification factor. Default is 1
		/// </summary>
		// Token: 0x06003651 RID: 13905 RVA: 0x0004F4E8 File Offset: 0x0004D6E8
		public virtual int GetMagnification()
		{
			return vtkImageDataLIC2D.vtkImageDataLIC2D_GetMagnification_02(base.GetCppThis());
		}

		// Token: 0x06003652 RID: 13906
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageDataLIC2D_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003653 RID: 13907 RVA: 0x0004F508 File Offset: 0x0004D708
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageDataLIC2D.vtkImageDataLIC2D_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06003654 RID: 13908
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageDataLIC2D_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003655 RID: 13909 RVA: 0x0004F528 File Offset: 0x0004D728
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageDataLIC2D.vtkImageDataLIC2D_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06003656 RID: 13910
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDataLIC2D_GetOpenGLExtensionsSupported_05(HandleRef pThis);

		/// <summary>
		/// Check if the required OpenGL extensions / GPU are supported.
		/// </summary>
		// Token: 0x06003657 RID: 13911 RVA: 0x0004F544 File Offset: 0x0004D744
		public virtual int GetOpenGLExtensionsSupported()
		{
			return vtkImageDataLIC2D.vtkImageDataLIC2D_GetOpenGLExtensionsSupported_05(base.GetCppThis());
		}

		// Token: 0x06003658 RID: 13912
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageDataLIC2D_GetStepSize_06(HandleRef pThis);

		/// <summary>
		/// Step size.
		/// Specify the step size as a unit of the cell length of the input vector
		/// field. Cell length is the length of the diagonal of a cell.
		/// Initial value is 1.0.
		/// class invariant: StepSize&gt;0.0.
		/// In term of visual quality, the smaller the better.
		/// The type for the interface is double as VTK interface is double
		/// but GPU only supports float. This value will be converted to
		/// float in the execution of the algorithm.
		/// </summary>
		// Token: 0x06003659 RID: 13913 RVA: 0x0004F564 File Offset: 0x0004D764
		public virtual double GetStepSize()
		{
			return vtkImageDataLIC2D.vtkImageDataLIC2D_GetStepSize_06(base.GetCppThis());
		}

		// Token: 0x0600365A RID: 13914
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDataLIC2D_GetSteps_07(HandleRef pThis);

		/// <summary>
		/// Number of steps. Initial value is 20.
		/// class invariant: Steps&gt;0.
		/// In term of visual quality, the greater the better.
		/// </summary>
		// Token: 0x0600365B RID: 13915 RVA: 0x0004F584 File Offset: 0x0004D784
		public virtual int GetSteps()
		{
			return vtkImageDataLIC2D.vtkImageDataLIC2D_GetSteps_07(base.GetCppThis());
		}

		// Token: 0x0600365C RID: 13916
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDataLIC2D_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600365D RID: 13917 RVA: 0x0004F5A4 File Offset: 0x0004D7A4
		public override int IsA(string type)
		{
			return vtkImageDataLIC2D.vtkImageDataLIC2D_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0600365E RID: 13918
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDataLIC2D_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600365F RID: 13919 RVA: 0x0004F5C4 File Offset: 0x0004D7C4
		public new static int IsTypeOf(string type)
		{
			return vtkImageDataLIC2D.vtkImageDataLIC2D_IsTypeOf_09(type);
		}

		// Token: 0x06003660 RID: 13920
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDataLIC2D_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003661 RID: 13921 RVA: 0x0004F5E0 File Offset: 0x0004D7E0
		public new vtkImageDataLIC2D NewInstance()
		{
			vtkImageDataLIC2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDataLIC2D.vtkImageDataLIC2D_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDataLIC2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003662 RID: 13922
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDataLIC2D_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003663 RID: 13923 RVA: 0x0004F63C File Offset: 0x0004D83C
		public new static vtkImageDataLIC2D SafeDownCast(vtkObjectBase o)
		{
			vtkImageDataLIC2D vtkImageDataLIC2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDataLIC2D.vtkImageDataLIC2D_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageDataLIC2D = (vtkImageDataLIC2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageDataLIC2D.Register(null);
				}
			}
			return vtkImageDataLIC2D;
		}

		// Token: 0x06003664 RID: 13924
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDataLIC2D_SetContext_13(HandleRef pThis, HandleRef context);

		/// <summary>
		/// Get/Set the context. Context must be a vtkOpenGLRenderWindow.
		/// This does not increase the reference count of the
		/// context to avoid reference loops.
		/// SetContext() may raise an error if the OpenGL context does not support the
		/// required OpenGL extensions. Return 0 upon failure and 1 upon success.
		/// </summary>
		// Token: 0x06003665 RID: 13925 RVA: 0x0004F6BC File Offset: 0x0004D8BC
		public int SetContext(vtkRenderWindow context)
		{
			return vtkImageDataLIC2D.vtkImageDataLIC2D_SetContext_13(base.GetCppThis(), (context == null) ? default(HandleRef) : context.GetCppThis());
		}

		// Token: 0x06003666 RID: 13926
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDataLIC2D_SetMagnification_14(HandleRef pThis, int _arg);

		/// <summary>
		/// The magnification factor. Default is 1
		/// </summary>
		// Token: 0x06003667 RID: 13927 RVA: 0x0004F6F0 File Offset: 0x0004D8F0
		public virtual void SetMagnification(int _arg)
		{
			vtkImageDataLIC2D.vtkImageDataLIC2D_SetMagnification_14(base.GetCppThis(), _arg);
		}

		// Token: 0x06003668 RID: 13928
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDataLIC2D_SetStepSize_15(HandleRef pThis, double _arg);

		/// <summary>
		/// Step size.
		/// Specify the step size as a unit of the cell length of the input vector
		/// field. Cell length is the length of the diagonal of a cell.
		/// Initial value is 1.0.
		/// class invariant: StepSize&gt;0.0.
		/// In term of visual quality, the smaller the better.
		/// The type for the interface is double as VTK interface is double
		/// but GPU only supports float. This value will be converted to
		/// float in the execution of the algorithm.
		/// </summary>
		// Token: 0x06003669 RID: 13929 RVA: 0x0004F700 File Offset: 0x0004D900
		public virtual void SetStepSize(double _arg)
		{
			vtkImageDataLIC2D.vtkImageDataLIC2D_SetStepSize_15(base.GetCppThis(), _arg);
		}

		// Token: 0x0600366A RID: 13930
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDataLIC2D_SetSteps_16(HandleRef pThis, int _arg);

		/// <summary>
		/// Number of steps. Initial value is 20.
		/// class invariant: Steps&gt;0.
		/// In term of visual quality, the greater the better.
		/// </summary>
		// Token: 0x0600366B RID: 13931 RVA: 0x0004F710 File Offset: 0x0004D910
		public virtual void SetSteps(int _arg)
		{
			vtkImageDataLIC2D.vtkImageDataLIC2D_SetSteps_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0600366C RID: 13932
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDataLIC2D_TranslateInputExtent_17(HandleRef pThis, IntPtr inExt, IntPtr inWholeExtent, IntPtr outExt);

		/// <summary>
		/// Check if the required OpenGL extensions / GPU are supported.
		/// </summary>
		// Token: 0x0600366D RID: 13933 RVA: 0x0004F720 File Offset: 0x0004D920
		public void TranslateInputExtent(IntPtr inExt, IntPtr inWholeExtent, IntPtr outExt)
		{
			vtkImageDataLIC2D.vtkImageDataLIC2D_TranslateInputExtent_17(base.GetCppThis(), inExt, inWholeExtent, outExt);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400064A RID: 1610
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageDataLIC2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400064B RID: 1611
		public new static readonly string MRClassNameKey = "class vtkImageDataLIC2D";
	}
}
