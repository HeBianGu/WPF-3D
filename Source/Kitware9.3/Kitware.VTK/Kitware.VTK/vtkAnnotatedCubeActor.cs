﻿using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAnnotatedCubeActor
	/// </summary>
	/// <remarks>
	///    a 3D cube with face labels
	///
	/// vtkAnnotatedCubeActor is a hybrid 3D actor used to represent an anatomical
	/// orientation marker in a scene.  The class consists of a 3D unit cube centered
	/// on the origin with each face labelled in correspondence to a particular
	/// coordinate direction.  For example, with Cartesian directions, the user
	/// defined text labels could be: +X, -X, +Y, -Y, +Z, -Z, while for anatomical
	/// directions: A, P, L, R, S, I.  Text is automatically centered on each cube
	/// face and is not restriceted to single characters. In addition to or in
	/// replace of a solid text label representation, the outline edges of the labels
	/// can be displayed.  The individual properties of the cube, face labels
	/// and text outlines can be manipulated as can their visibility.
	///
	/// @warning
	/// vtkAnnotatedCubeActor is primarily intended for use with
	/// vtkOrientationMarkerWidget. The cube face text is generated by vtkVectorText
	/// and therefore the font attributes are restricted.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAxesActor vtkOrientationMarkerWidget vtkVectorText
	/// </seealso>
	// Token: 0x020003B0 RID: 944
	public class vtkAnnotatedCubeActor : vtkProp3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600AC1C RID: 44060 RVA: 0x000F44AB File Offset: 0x000F26AB
		static vtkAnnotatedCubeActor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAnnotatedCubeActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAnnotatedCubeActor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600AC1D RID: 44061 RVA: 0x000F44D3 File Offset: 0x000F26D3
		public vtkAnnotatedCubeActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600AC1E RID: 44062
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotatedCubeActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AC1F RID: 44063 RVA: 0x000F44E4 File Offset: 0x000F26E4
		public new static vtkAnnotatedCubeActor New()
		{
			vtkAnnotatedCubeActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAnnotatedCubeActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AC20 RID: 44064 RVA: 0x000F4538 File Offset: 0x000F2738
		public vtkAnnotatedCubeActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600AC21 RID: 44065 RVA: 0x000F457C File Offset: 0x000F277C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600AC22 RID: 44066
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnnotatedCubeActor_GetActors_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// For some exporters and other other operations we must be
		/// able to collect all the actors or volumes. These methods
		/// are used in that process.
		/// </summary>
		// Token: 0x0600AC23 RID: 44067 RVA: 0x000F4588 File Offset: 0x000F2788
		public override void GetActors(vtkPropCollection arg0)
		{
			vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetActors_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600AC24 RID: 44068
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotatedCubeActor_GetAssembly_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the assembly so that user supplied transforms can be applied
		/// </summary>
		// Token: 0x0600AC25 RID: 44069 RVA: 0x000F45B8 File Offset: 0x000F27B8
		public vtkAssembly GetAssembly()
		{
			vtkAssembly vtkAssembly = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetAssembly_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAssembly = (vtkAssembly)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAssembly.Register(null);
				}
			}
			return vtkAssembly;
		}

		// Token: 0x0600AC26 RID: 44070
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnnotatedCubeActor_GetBounds_03(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Get the bounds for this Actor as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax). (The
		/// method GetBounds(double bounds[6]) is available from the superclass.)
		/// </summary>
		// Token: 0x0600AC27 RID: 44071 RVA: 0x000F4627 File Offset: 0x000F2827
		public new void GetBounds(IntPtr bounds)
		{
			vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetBounds_03(base.GetCppThis(), bounds);
		}

		// Token: 0x0600AC28 RID: 44072
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotatedCubeActor_GetBounds_04(HandleRef pThis);

		/// <summary>
		/// Get the bounds for this Actor as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax). (The
		/// method GetBounds(double bounds[6]) is available from the superclass.)
		/// </summary>
		// Token: 0x0600AC29 RID: 44073 RVA: 0x000F4638 File Offset: 0x000F2838
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetBounds_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600AC2A RID: 44074
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotatedCubeActor_GetCubeProperty_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the cube properties.
		/// </summary>
		// Token: 0x0600AC2B RID: 44075 RVA: 0x000F4680 File Offset: 0x000F2880
		public vtkProperty GetCubeProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetCubeProperty_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x0600AC2C RID: 44076
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAnnotatedCubeActor_GetCubeVisibility_06(HandleRef pThis);

		/// <summary>
		/// Enable/disable drawing the cube.
		/// </summary>
		// Token: 0x0600AC2D RID: 44077 RVA: 0x000F46F0 File Offset: 0x000F28F0
		public int GetCubeVisibility()
		{
			return vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetCubeVisibility_06(base.GetCppThis());
		}

		// Token: 0x0600AC2E RID: 44078
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAnnotatedCubeActor_GetFaceTextScale_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the scale factor for the face text
		/// </summary>
		// Token: 0x0600AC2F RID: 44079 RVA: 0x000F4710 File Offset: 0x000F2910
		public virtual double GetFaceTextScale()
		{
			return vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetFaceTextScale_07(base.GetCppThis());
		}

		// Token: 0x0600AC30 RID: 44080
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAnnotatedCubeActor_GetFaceTextVisibility_08(HandleRef pThis);

		/// <summary>
		/// Enable/disable drawing the vector text.
		/// </summary>
		// Token: 0x0600AC31 RID: 44081 RVA: 0x000F4730 File Offset: 0x000F2930
		public int GetFaceTextVisibility()
		{
			return vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetFaceTextVisibility_08(base.GetCppThis());
		}

		// Token: 0x0600AC32 RID: 44082
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkAnnotatedCubeActor_GetMTime_09(HandleRef pThis);

		/// <summary>
		/// Get the actors mtime plus consider its properties and texture if set.
		/// </summary>
		// Token: 0x0600AC33 RID: 44083 RVA: 0x000F4750 File Offset: 0x000F2950
		public override ulong GetMTime()
		{
			return vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetMTime_09(base.GetCppThis());
		}

		// Token: 0x0600AC34 RID: 44084
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAnnotatedCubeActor_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AC35 RID: 44085 RVA: 0x000F4770 File Offset: 0x000F2970
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x0600AC36 RID: 44086
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAnnotatedCubeActor_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AC37 RID: 44087 RVA: 0x000F4790 File Offset: 0x000F2990
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x0600AC38 RID: 44088
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotatedCubeActor_GetTextEdgesProperty_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the text edges properties.
		/// </summary>
		// Token: 0x0600AC39 RID: 44089 RVA: 0x000F47AC File Offset: 0x000F29AC
		public vtkProperty GetTextEdgesProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetTextEdgesProperty_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x0600AC3A RID: 44090
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAnnotatedCubeActor_GetTextEdgesVisibility_13(HandleRef pThis);

		/// <summary>
		/// Enable/disable drawing the vector text edges.
		/// </summary>
		// Token: 0x0600AC3B RID: 44091 RVA: 0x000F481C File Offset: 0x000F2A1C
		public int GetTextEdgesVisibility()
		{
			return vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetTextEdgesVisibility_13(base.GetCppThis());
		}

		// Token: 0x0600AC3C RID: 44092
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAnnotatedCubeActor_GetXFaceTextRotation_14(HandleRef pThis);

		/// <summary>
		/// Augment individual face text orientations.
		/// </summary>
		// Token: 0x0600AC3D RID: 44093 RVA: 0x000F483C File Offset: 0x000F2A3C
		public virtual double GetXFaceTextRotation()
		{
			return vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetXFaceTextRotation_14(base.GetCppThis());
		}

		// Token: 0x0600AC3E RID: 44094
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotatedCubeActor_GetXMinusFaceProperty_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the individual face text properties.
		/// </summary>
		// Token: 0x0600AC3F RID: 44095 RVA: 0x000F485C File Offset: 0x000F2A5C
		public vtkProperty GetXMinusFaceProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetXMinusFaceProperty_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x0600AC40 RID: 44096
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotatedCubeActor_GetXMinusFaceText_16(HandleRef pThis);

		/// <summary>
		/// Set/get the face text.
		/// </summary>
		// Token: 0x0600AC41 RID: 44097 RVA: 0x000F48CC File Offset: 0x000F2ACC
		public virtual string GetXMinusFaceText()
		{
			string s = Marshal.PtrToStringAnsi(vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetXMinusFaceText_16(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600AC42 RID: 44098
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotatedCubeActor_GetXPlusFaceProperty_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the individual face text properties.
		/// </summary>
		// Token: 0x0600AC43 RID: 44099 RVA: 0x000F4908 File Offset: 0x000F2B08
		public vtkProperty GetXPlusFaceProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetXPlusFaceProperty_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x0600AC44 RID: 44100
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotatedCubeActor_GetXPlusFaceText_18(HandleRef pThis);

		/// <summary>
		/// Set/get the face text.
		/// </summary>
		// Token: 0x0600AC45 RID: 44101 RVA: 0x000F4978 File Offset: 0x000F2B78
		public virtual string GetXPlusFaceText()
		{
			string s = Marshal.PtrToStringAnsi(vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetXPlusFaceText_18(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600AC46 RID: 44102
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAnnotatedCubeActor_GetYFaceTextRotation_19(HandleRef pThis);

		/// <summary>
		/// Augment individual face text orientations.
		/// </summary>
		// Token: 0x0600AC47 RID: 44103 RVA: 0x000F49B4 File Offset: 0x000F2BB4
		public virtual double GetYFaceTextRotation()
		{
			return vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetYFaceTextRotation_19(base.GetCppThis());
		}

		// Token: 0x0600AC48 RID: 44104
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotatedCubeActor_GetYMinusFaceProperty_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the individual face text properties.
		/// </summary>
		// Token: 0x0600AC49 RID: 44105 RVA: 0x000F49D4 File Offset: 0x000F2BD4
		public vtkProperty GetYMinusFaceProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetYMinusFaceProperty_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x0600AC4A RID: 44106
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotatedCubeActor_GetYMinusFaceText_21(HandleRef pThis);

		/// <summary>
		/// Set/get the face text.
		/// </summary>
		// Token: 0x0600AC4B RID: 44107 RVA: 0x000F4A44 File Offset: 0x000F2C44
		public virtual string GetYMinusFaceText()
		{
			string s = Marshal.PtrToStringAnsi(vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetYMinusFaceText_21(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600AC4C RID: 44108
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotatedCubeActor_GetYPlusFaceProperty_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the individual face text properties.
		/// </summary>
		// Token: 0x0600AC4D RID: 44109 RVA: 0x000F4A80 File Offset: 0x000F2C80
		public vtkProperty GetYPlusFaceProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetYPlusFaceProperty_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x0600AC4E RID: 44110
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotatedCubeActor_GetYPlusFaceText_23(HandleRef pThis);

		/// <summary>
		/// Set/get the face text.
		/// </summary>
		// Token: 0x0600AC4F RID: 44111 RVA: 0x000F4AF0 File Offset: 0x000F2CF0
		public virtual string GetYPlusFaceText()
		{
			string s = Marshal.PtrToStringAnsi(vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetYPlusFaceText_23(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600AC50 RID: 44112
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAnnotatedCubeActor_GetZFaceTextRotation_24(HandleRef pThis);

		/// <summary>
		/// Augment individual face text orientations.
		/// </summary>
		// Token: 0x0600AC51 RID: 44113 RVA: 0x000F4B2C File Offset: 0x000F2D2C
		public virtual double GetZFaceTextRotation()
		{
			return vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetZFaceTextRotation_24(base.GetCppThis());
		}

		// Token: 0x0600AC52 RID: 44114
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotatedCubeActor_GetZMinusFaceProperty_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the individual face text properties.
		/// </summary>
		// Token: 0x0600AC53 RID: 44115 RVA: 0x000F4B4C File Offset: 0x000F2D4C
		public vtkProperty GetZMinusFaceProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetZMinusFaceProperty_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x0600AC54 RID: 44116
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotatedCubeActor_GetZMinusFaceText_26(HandleRef pThis);

		/// <summary>
		/// Set/get the face text.
		/// </summary>
		// Token: 0x0600AC55 RID: 44117 RVA: 0x000F4BBC File Offset: 0x000F2DBC
		public virtual string GetZMinusFaceText()
		{
			string s = Marshal.PtrToStringAnsi(vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetZMinusFaceText_26(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600AC56 RID: 44118
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotatedCubeActor_GetZPlusFaceProperty_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the individual face text properties.
		/// </summary>
		// Token: 0x0600AC57 RID: 44119 RVA: 0x000F4BF8 File Offset: 0x000F2DF8
		public vtkProperty GetZPlusFaceProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetZPlusFaceProperty_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x0600AC58 RID: 44120
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotatedCubeActor_GetZPlusFaceText_28(HandleRef pThis);

		/// <summary>
		/// Set/get the face text.
		/// </summary>
		// Token: 0x0600AC59 RID: 44121 RVA: 0x000F4C68 File Offset: 0x000F2E68
		public virtual string GetZPlusFaceText()
		{
			string s = Marshal.PtrToStringAnsi(vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetZPlusFaceText_28(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600AC5A RID: 44122
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAnnotatedCubeActor_HasTranslucentPolygonalGeometry_29(HandleRef pThis);

		/// <summary>
		/// Does this prop have some translucent polygonal geometry?
		/// </summary>
		// Token: 0x0600AC5B RID: 44123 RVA: 0x000F4CA4 File Offset: 0x000F2EA4
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_HasTranslucentPolygonalGeometry_29(base.GetCppThis());
		}

		// Token: 0x0600AC5C RID: 44124
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAnnotatedCubeActor_IsA_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AC5D RID: 44125 RVA: 0x000F4CC4 File Offset: 0x000F2EC4
		public override int IsA(string type)
		{
			return vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_IsA_30(base.GetCppThis(), type);
		}

		// Token: 0x0600AC5E RID: 44126
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAnnotatedCubeActor_IsTypeOf_31([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AC5F RID: 44127 RVA: 0x000F4CE4 File Offset: 0x000F2EE4
		public new static int IsTypeOf(string type)
		{
			return vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_IsTypeOf_31(type);
		}

		// Token: 0x0600AC60 RID: 44128
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotatedCubeActor_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AC61 RID: 44129 RVA: 0x000F4D00 File Offset: 0x000F2F00
		public new vtkAnnotatedCubeActor NewInstance()
		{
			vtkAnnotatedCubeActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_NewInstance_33(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAnnotatedCubeActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600AC62 RID: 44130
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnnotatedCubeActor_ReleaseGraphicsResources_34(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this actor.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0600AC63 RID: 44131 RVA: 0x000F4D5C File Offset: 0x000F2F5C
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_ReleaseGraphicsResources_34(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600AC64 RID: 44132
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAnnotatedCubeActor_RenderOpaqueGeometry_35(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Support the standard render methods.
		/// </summary>
		// Token: 0x0600AC65 RID: 44133 RVA: 0x000F4D8C File Offset: 0x000F2F8C
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_RenderOpaqueGeometry_35(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600AC66 RID: 44134
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAnnotatedCubeActor_RenderTranslucentPolygonalGeometry_36(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Support the standard render methods.
		/// </summary>
		// Token: 0x0600AC67 RID: 44135 RVA: 0x000F4DC0 File Offset: 0x000F2FC0
		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_RenderTranslucentPolygonalGeometry_36(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600AC68 RID: 44136
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotatedCubeActor_SafeDownCast_37(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AC69 RID: 44137 RVA: 0x000F4DF4 File Offset: 0x000F2FF4
		public new static vtkAnnotatedCubeActor SafeDownCast(vtkObjectBase o)
		{
			vtkAnnotatedCubeActor vtkAnnotatedCubeActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_SafeDownCast_37((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAnnotatedCubeActor = (vtkAnnotatedCubeActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAnnotatedCubeActor.Register(null);
				}
			}
			return vtkAnnotatedCubeActor;
		}

		// Token: 0x0600AC6A RID: 44138
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnnotatedCubeActor_SetCubeVisibility_38(HandleRef pThis, int arg0);

		/// <summary>
		/// Enable/disable drawing the cube.
		/// </summary>
		// Token: 0x0600AC6B RID: 44139 RVA: 0x000F4E73 File Offset: 0x000F3073
		public void SetCubeVisibility(int arg0)
		{
			vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_SetCubeVisibility_38(base.GetCppThis(), arg0);
		}

		// Token: 0x0600AC6C RID: 44140
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnnotatedCubeActor_SetFaceTextScale_39(HandleRef pThis, double arg0);

		/// <summary>
		/// Set/Get the scale factor for the face text
		/// </summary>
		// Token: 0x0600AC6D RID: 44141 RVA: 0x000F4E83 File Offset: 0x000F3083
		public void SetFaceTextScale(double arg0)
		{
			vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_SetFaceTextScale_39(base.GetCppThis(), arg0);
		}

		// Token: 0x0600AC6E RID: 44142
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnnotatedCubeActor_SetFaceTextVisibility_40(HandleRef pThis, int arg0);

		/// <summary>
		/// Enable/disable drawing the vector text.
		/// </summary>
		// Token: 0x0600AC6F RID: 44143 RVA: 0x000F4E93 File Offset: 0x000F3093
		public void SetFaceTextVisibility(int arg0)
		{
			vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_SetFaceTextVisibility_40(base.GetCppThis(), arg0);
		}

		// Token: 0x0600AC70 RID: 44144
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnnotatedCubeActor_SetTextEdgesVisibility_41(HandleRef pThis, int arg0);

		/// <summary>
		/// Enable/disable drawing the vector text edges.
		/// </summary>
		// Token: 0x0600AC71 RID: 44145 RVA: 0x000F4EA3 File Offset: 0x000F30A3
		public void SetTextEdgesVisibility(int arg0)
		{
			vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_SetTextEdgesVisibility_41(base.GetCppThis(), arg0);
		}

		// Token: 0x0600AC72 RID: 44146
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnnotatedCubeActor_SetXFaceTextRotation_42(HandleRef pThis, double _arg);

		/// <summary>
		/// Augment individual face text orientations.
		/// </summary>
		// Token: 0x0600AC73 RID: 44147 RVA: 0x000F4EB3 File Offset: 0x000F30B3
		public virtual void SetXFaceTextRotation(double _arg)
		{
			vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_SetXFaceTextRotation_42(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AC74 RID: 44148
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnnotatedCubeActor_SetXMinusFaceText_43(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/get the face text.
		/// </summary>
		// Token: 0x0600AC75 RID: 44149 RVA: 0x000F4EC3 File Offset: 0x000F30C3
		public virtual void SetXMinusFaceText(string _arg)
		{
			vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_SetXMinusFaceText_43(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AC76 RID: 44150
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnnotatedCubeActor_SetXPlusFaceText_44(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/get the face text.
		/// </summary>
		// Token: 0x0600AC77 RID: 44151 RVA: 0x000F4ED3 File Offset: 0x000F30D3
		public virtual void SetXPlusFaceText(string _arg)
		{
			vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_SetXPlusFaceText_44(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AC78 RID: 44152
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnnotatedCubeActor_SetYFaceTextRotation_45(HandleRef pThis, double _arg);

		/// <summary>
		/// Augment individual face text orientations.
		/// </summary>
		// Token: 0x0600AC79 RID: 44153 RVA: 0x000F4EE3 File Offset: 0x000F30E3
		public virtual void SetYFaceTextRotation(double _arg)
		{
			vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_SetYFaceTextRotation_45(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AC7A RID: 44154
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnnotatedCubeActor_SetYMinusFaceText_46(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/get the face text.
		/// </summary>
		// Token: 0x0600AC7B RID: 44155 RVA: 0x000F4EF3 File Offset: 0x000F30F3
		public virtual void SetYMinusFaceText(string _arg)
		{
			vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_SetYMinusFaceText_46(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AC7C RID: 44156
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnnotatedCubeActor_SetYPlusFaceText_47(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/get the face text.
		/// </summary>
		// Token: 0x0600AC7D RID: 44157 RVA: 0x000F4F03 File Offset: 0x000F3103
		public virtual void SetYPlusFaceText(string _arg)
		{
			vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_SetYPlusFaceText_47(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AC7E RID: 44158
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnnotatedCubeActor_SetZFaceTextRotation_48(HandleRef pThis, double _arg);

		/// <summary>
		/// Augment individual face text orientations.
		/// </summary>
		// Token: 0x0600AC7F RID: 44159 RVA: 0x000F4F13 File Offset: 0x000F3113
		public virtual void SetZFaceTextRotation(double _arg)
		{
			vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_SetZFaceTextRotation_48(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AC80 RID: 44160
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnnotatedCubeActor_SetZMinusFaceText_49(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/get the face text.
		/// </summary>
		// Token: 0x0600AC81 RID: 44161 RVA: 0x000F4F23 File Offset: 0x000F3123
		public virtual void SetZMinusFaceText(string _arg)
		{
			vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_SetZMinusFaceText_49(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AC82 RID: 44162
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnnotatedCubeActor_SetZPlusFaceText_50(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/get the face text.
		/// </summary>
		// Token: 0x0600AC83 RID: 44163 RVA: 0x000F4F33 File Offset: 0x000F3133
		public virtual void SetZPlusFaceText(string _arg)
		{
			vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_SetZPlusFaceText_50(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AC84 RID: 44164
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnnotatedCubeActor_ShallowCopy_51(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Shallow copy of an axes actor. Overloads the virtual vtkProp method.
		/// </summary>
		// Token: 0x0600AC85 RID: 44165 RVA: 0x000F4F44 File Offset: 0x000F3144
		public override void ShallowCopy(vtkProp prop)
		{
			vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_ShallowCopy_51(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D95 RID: 3477
		public new const string MRFullTypeName = "Kitware.VTK.vtkAnnotatedCubeActor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D96 RID: 3478
		public new static readonly string MRClassNameKey = "class vtkAnnotatedCubeActor";
	}
}
