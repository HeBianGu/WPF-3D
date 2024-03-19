﻿using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStructuredGridLIC2D
	///
	/// GPU implementation of a Line Integral Convolution, a technique for
	/// imaging vector fields.
	///
	/// The input on port 0 is an 2D vtkStructuredGrid. It needs
	/// a vector field on point data.
	/// Port 1 is a special port for customized noise input. It is an optional port.
	/// If not present, noise is generated by the filter. Even if none-power-of-two
	/// texture are supported, giving a power-of-two image may result in faster
	/// execution on the GPU.
	///
	/// Please refer to Forssell, L. K., "Visualizing flow over curvilinear grid
	/// surfaces using line integral convolution", Visualization 94 Conference
	/// Proceedings, pages 240-247, IEEE Computer Society, 1994 for details of the
	/// algorithm.
	///
	/// @par Required OpenGL Extensions:
	/// GL_ARB_texture_non_power_of_two
	/// GL_VERSION_2_0
	/// GL_ARB_texture_float
	/// GL_ARB_draw_buffers
	/// GL_EXT_framebuffer_object
	/// GL_ARB_pixel_buffer_object
	/// </summary>
	// Token: 0x0200010B RID: 267
	public class vtkStructuredGridLIC2D : vtkStructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003694 RID: 13972 RVA: 0x0004FC7F File Offset: 0x0004DE7F
		static vtkStructuredGridLIC2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStructuredGridLIC2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredGridLIC2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003695 RID: 13973 RVA: 0x0004FCA7 File Offset: 0x0004DEA7
		public vtkStructuredGridLIC2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003696 RID: 13974
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridLIC2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003697 RID: 13975 RVA: 0x0004FCB8 File Offset: 0x0004DEB8
		public new static vtkStructuredGridLIC2D New()
		{
			vtkStructuredGridLIC2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGridLIC2D.vtkStructuredGridLIC2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredGridLIC2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003698 RID: 13976 RVA: 0x0004FD0C File Offset: 0x0004DF0C
		public vtkStructuredGridLIC2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStructuredGridLIC2D.vtkStructuredGridLIC2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003699 RID: 13977 RVA: 0x0004FD50 File Offset: 0x0004DF50
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600369A RID: 13978
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridLIC2D_GetContext_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the context. Context must be a vtkOpenGLRenderWindow.
		/// This does not increase the reference count of the
		/// context to avoid reference loops.
		/// SetContext() may raise an error if the OpenGL context does not support the
		/// required OpenGL extensions. Return 0 upon failure and 1 upon success.
		/// </summary>
		// Token: 0x0600369B RID: 13979 RVA: 0x0004FD5C File Offset: 0x0004DF5C
		public vtkRenderWindow GetContext()
		{
			vtkRenderWindow vtkRenderWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGridLIC2D.vtkStructuredGridLIC2D_GetContext_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600369C RID: 13980
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGridLIC2D_GetFBOSuccess_02(HandleRef pThis);

		/// <summary>
		/// Check if FBO is started properly.
		/// </summary>
		// Token: 0x0600369D RID: 13981 RVA: 0x0004FDCC File Offset: 0x0004DFCC
		public int GetFBOSuccess()
		{
			return vtkStructuredGridLIC2D.vtkStructuredGridLIC2D_GetFBOSuccess_02(base.GetCppThis());
		}

		// Token: 0x0600369E RID: 13982
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGridLIC2D_GetLICSuccess_03(HandleRef pThis);

		/// <summary>
		/// Check if LIC runs properly.
		/// </summary>
		// Token: 0x0600369F RID: 13983 RVA: 0x0004FDEC File Offset: 0x0004DFEC
		public int GetLICSuccess()
		{
			return vtkStructuredGridLIC2D.vtkStructuredGridLIC2D_GetLICSuccess_03(base.GetCppThis());
		}

		// Token: 0x060036A0 RID: 13984
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGridLIC2D_GetMagnification_04(HandleRef pThis);

		/// <summary>
		/// The magnification factor. Default is 1
		/// </summary>
		// Token: 0x060036A1 RID: 13985 RVA: 0x0004FE0C File Offset: 0x0004E00C
		public virtual int GetMagnification()
		{
			return vtkStructuredGridLIC2D.vtkStructuredGridLIC2D_GetMagnification_04(base.GetCppThis());
		}

		// Token: 0x060036A2 RID: 13986
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGridLIC2D_GetMagnificationMaxValue_05(HandleRef pThis);

		/// <summary>
		/// The magnification factor. Default is 1
		/// </summary>
		// Token: 0x060036A3 RID: 13987 RVA: 0x0004FE2C File Offset: 0x0004E02C
		public virtual int GetMagnificationMaxValue()
		{
			return vtkStructuredGridLIC2D.vtkStructuredGridLIC2D_GetMagnificationMaxValue_05(base.GetCppThis());
		}

		// Token: 0x060036A4 RID: 13988
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGridLIC2D_GetMagnificationMinValue_06(HandleRef pThis);

		/// <summary>
		/// The magnification factor. Default is 1
		/// </summary>
		// Token: 0x060036A5 RID: 13989 RVA: 0x0004FE4C File Offset: 0x0004E04C
		public virtual int GetMagnificationMinValue()
		{
			return vtkStructuredGridLIC2D.vtkStructuredGridLIC2D_GetMagnificationMinValue_06(base.GetCppThis());
		}

		// Token: 0x060036A6 RID: 13990
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredGridLIC2D_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060036A7 RID: 13991 RVA: 0x0004FE6C File Offset: 0x0004E06C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStructuredGridLIC2D.vtkStructuredGridLIC2D_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x060036A8 RID: 13992
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredGridLIC2D_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060036A9 RID: 13993 RVA: 0x0004FE8C File Offset: 0x0004E08C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStructuredGridLIC2D.vtkStructuredGridLIC2D_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x060036AA RID: 13994
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkStructuredGridLIC2D_GetStepSize_09(HandleRef pThis);

		/// <summary>
		/// Step size.
		/// WE ARE NOT SURE YET about the space where we define the step.
		/// If the image data has different spacing in each dimension, it
		/// is an issue.
		/// Initial value is 1.0.
		/// class invariant: StepSize&gt;0.0.
		/// In term of visual quality, the smaller the better.
		/// The type for the interface is double as VTK interface is double
		/// but GPU only supports float. This value will be converted to
		/// float in the execution of the algorithm.
		/// </summary>
		// Token: 0x060036AB RID: 13995 RVA: 0x0004FEA8 File Offset: 0x0004E0A8
		public virtual double GetStepSize()
		{
			return vtkStructuredGridLIC2D.vtkStructuredGridLIC2D_GetStepSize_09(base.GetCppThis());
		}

		// Token: 0x060036AC RID: 13996
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGridLIC2D_GetSteps_10(HandleRef pThis);

		/// <summary>
		/// Number of steps. Initial value is 1.
		/// class invariant: Steps&gt;0.
		/// In term of visual quality, the greater the better.
		/// </summary>
		// Token: 0x060036AD RID: 13997 RVA: 0x0004FEC8 File Offset: 0x0004E0C8
		public virtual int GetSteps()
		{
			return vtkStructuredGridLIC2D.vtkStructuredGridLIC2D_GetSteps_10(base.GetCppThis());
		}

		// Token: 0x060036AE RID: 13998
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGridLIC2D_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060036AF RID: 13999 RVA: 0x0004FEE8 File Offset: 0x0004E0E8
		public override int IsA(string type)
		{
			return vtkStructuredGridLIC2D.vtkStructuredGridLIC2D_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x060036B0 RID: 14000
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGridLIC2D_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060036B1 RID: 14001 RVA: 0x0004FF08 File Offset: 0x0004E108
		public new static int IsTypeOf(string type)
		{
			return vtkStructuredGridLIC2D.vtkStructuredGridLIC2D_IsTypeOf_12(type);
		}

		// Token: 0x060036B2 RID: 14002
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridLIC2D_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060036B3 RID: 14003 RVA: 0x0004FF24 File Offset: 0x0004E124
		public new vtkStructuredGridLIC2D NewInstance()
		{
			vtkStructuredGridLIC2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGridLIC2D.vtkStructuredGridLIC2D_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredGridLIC2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060036B4 RID: 14004
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridLIC2D_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060036B5 RID: 14005 RVA: 0x0004FF80 File Offset: 0x0004E180
		public new static vtkStructuredGridLIC2D SafeDownCast(vtkObjectBase o)
		{
			vtkStructuredGridLIC2D vtkStructuredGridLIC2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGridLIC2D.vtkStructuredGridLIC2D_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGridLIC2D = (vtkStructuredGridLIC2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGridLIC2D.Register(null);
				}
			}
			return vtkStructuredGridLIC2D;
		}

		// Token: 0x060036B6 RID: 14006
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGridLIC2D_SetContext_16(HandleRef pThis, HandleRef context);

		/// <summary>
		/// Get/Set the context. Context must be a vtkOpenGLRenderWindow.
		/// This does not increase the reference count of the
		/// context to avoid reference loops.
		/// SetContext() may raise an error if the OpenGL context does not support the
		/// required OpenGL extensions. Return 0 upon failure and 1 upon success.
		/// </summary>
		// Token: 0x060036B7 RID: 14007 RVA: 0x00050000 File Offset: 0x0004E200
		public int SetContext(vtkRenderWindow context)
		{
			return vtkStructuredGridLIC2D.vtkStructuredGridLIC2D_SetContext_16(base.GetCppThis(), (context == null) ? default(HandleRef) : context.GetCppThis());
		}

		// Token: 0x060036B8 RID: 14008
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGridLIC2D_SetMagnification_17(HandleRef pThis, int _arg);

		/// <summary>
		/// The magnification factor. Default is 1
		/// </summary>
		// Token: 0x060036B9 RID: 14009 RVA: 0x00050034 File Offset: 0x0004E234
		public virtual void SetMagnification(int _arg)
		{
			vtkStructuredGridLIC2D.vtkStructuredGridLIC2D_SetMagnification_17(base.GetCppThis(), _arg);
		}

		// Token: 0x060036BA RID: 14010
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGridLIC2D_SetStepSize_18(HandleRef pThis, double _arg);

		/// <summary>
		/// Step size.
		/// WE ARE NOT SURE YET about the space where we define the step.
		/// If the image data has different spacing in each dimension, it
		/// is an issue.
		/// Initial value is 1.0.
		/// class invariant: StepSize&gt;0.0.
		/// In term of visual quality, the smaller the better.
		/// The type for the interface is double as VTK interface is double
		/// but GPU only supports float. This value will be converted to
		/// float in the execution of the algorithm.
		/// </summary>
		// Token: 0x060036BB RID: 14011 RVA: 0x00050044 File Offset: 0x0004E244
		public virtual void SetStepSize(double _arg)
		{
			vtkStructuredGridLIC2D.vtkStructuredGridLIC2D_SetStepSize_18(base.GetCppThis(), _arg);
		}

		// Token: 0x060036BC RID: 14012
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGridLIC2D_SetSteps_19(HandleRef pThis, int _arg);

		/// <summary>
		/// Number of steps. Initial value is 1.
		/// class invariant: Steps&gt;0.
		/// In term of visual quality, the greater the better.
		/// </summary>
		// Token: 0x060036BD RID: 14013 RVA: 0x00050054 File Offset: 0x0004E254
		public virtual void SetSteps(int _arg)
		{
			vtkStructuredGridLIC2D.vtkStructuredGridLIC2D_SetSteps_19(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400064E RID: 1614
		public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredGridLIC2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400064F RID: 1615
		public new static readonly string MRClassNameKey = "class vtkStructuredGridLIC2D";
	}
}