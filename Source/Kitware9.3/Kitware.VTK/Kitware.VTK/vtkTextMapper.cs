using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTextMapper
	/// </summary>
	/// <remarks>
	///    2D text annotation
	///
	/// vtkTextMapper provides 2D text annotation support for VTK.  It is a
	/// vtkMapper2D that can be associated with a vtkActor2D and placed into a
	/// vtkRenderer.
	///
	/// To use vtkTextMapper, specify an input text string.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkActor2D vtkTextActor vtkTextActor3D vtkTextProperty vtkTextRenderer
	/// </seealso>
	// Token: 0x020005D4 RID: 1492
	public class vtkTextMapper : vtkMapper2D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010491 RID: 66705 RVA: 0x0016B06F File Offset: 0x0016926F
		static vtkTextMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTextMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010492 RID: 66706 RVA: 0x0016B097 File Offset: 0x00169297
		public vtkTextMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010493 RID: 66707
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a new text mapper.
		/// </summary>
		// Token: 0x06010494 RID: 66708 RVA: 0x0016B0A8 File Offset: 0x001692A8
		public new static vtkTextMapper New()
		{
			vtkTextMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextMapper.vtkTextMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a new text mapper.
		/// </summary>
		// Token: 0x06010495 RID: 66709 RVA: 0x0016B0FC File Offset: 0x001692FC
		public vtkTextMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTextMapper.vtkTextMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010496 RID: 66710 RVA: 0x0016B140 File Offset: 0x00169340
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010497 RID: 66711
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextMapper_GetHeight_01(HandleRef pThis, HandleRef v);

		/// <summary>
		/// Return the size[2]/width/height of the rectangle required to draw this
		/// mapper (in pixels).
		/// </summary>
		// Token: 0x06010498 RID: 66712 RVA: 0x0016B14C File Offset: 0x0016934C
		public virtual int GetHeight(vtkViewport v)
		{
			return vtkTextMapper.vtkTextMapper_GetHeight_01(base.GetCppThis(), (v == null) ? default(HandleRef) : v.GetCppThis());
		}

		// Token: 0x06010499 RID: 66713
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextMapper_GetInput_02(HandleRef pThis);

		/// <summary>
		/// The input text string to the mapper.
		/// </summary>
		// Token: 0x0601049A RID: 66714 RVA: 0x0016B180 File Offset: 0x00169380
		public virtual string GetInput()
		{
			string s = Marshal.PtrToStringAnsi(vtkTextMapper.vtkTextMapper_GetInput_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601049B RID: 66715
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkTextMapper_GetMTime_03(HandleRef pThis);

		/// <summary>
		/// Use these methods when setting font size relative to the renderer's size. These
		/// methods are static so that external classes (e.g., widgets) can easily use them.
		/// </summary>
		// Token: 0x0601049C RID: 66716 RVA: 0x0016B1BC File Offset: 0x001693BC
		public override ulong GetMTime()
		{
			return vtkTextMapper.vtkTextMapper_GetMTime_03(base.GetCppThis());
		}

		// Token: 0x0601049D RID: 66717
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTextMapper_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601049E RID: 66718 RVA: 0x0016B1DC File Offset: 0x001693DC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTextMapper.vtkTextMapper_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601049F RID: 66719
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTextMapper_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060104A0 RID: 66720 RVA: 0x0016B1FC File Offset: 0x001693FC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTextMapper.vtkTextMapper_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x060104A1 RID: 66721
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextMapper_GetSize_06(HandleRef pThis, HandleRef arg0, IntPtr size);

		/// <summary>
		/// Return the size[2]/width/height of the rectangle required to draw this
		/// mapper (in pixels).
		/// </summary>
		// Token: 0x060104A2 RID: 66722 RVA: 0x0016B218 File Offset: 0x00169418
		public virtual void GetSize(vtkViewport arg0, IntPtr size)
		{
			vtkTextMapper.vtkTextMapper_GetSize_06(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), size);
		}

		// Token: 0x060104A3 RID: 66723
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextMapper_GetTextProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the text property.
		/// </summary>
		// Token: 0x060104A4 RID: 66724 RVA: 0x0016B248 File Offset: 0x00169448
		public virtual vtkTextProperty GetTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextMapper.vtkTextMapper_GetTextProperty_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		// Token: 0x060104A5 RID: 66725
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextMapper_GetWidth_08(HandleRef pThis, HandleRef v);

		/// <summary>
		/// Return the size[2]/width/height of the rectangle required to draw this
		/// mapper (in pixels).
		/// </summary>
		// Token: 0x060104A6 RID: 66726 RVA: 0x0016B2B8 File Offset: 0x001694B8
		public virtual int GetWidth(vtkViewport v)
		{
			return vtkTextMapper.vtkTextMapper_GetWidth_08(base.GetCppThis(), (v == null) ? default(HandleRef) : v.GetCppThis());
		}

		// Token: 0x060104A7 RID: 66727
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextMapper_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060104A8 RID: 66728 RVA: 0x0016B2EC File Offset: 0x001694EC
		public override int IsA(string type)
		{
			return vtkTextMapper.vtkTextMapper_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x060104A9 RID: 66729
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextMapper_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060104AA RID: 66730 RVA: 0x0016B30C File Offset: 0x0016950C
		public new static int IsTypeOf(string type)
		{
			return vtkTextMapper.vtkTextMapper_IsTypeOf_10(type);
		}

		// Token: 0x060104AB RID: 66731
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextMapper_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060104AC RID: 66732 RVA: 0x0016B328 File Offset: 0x00169528
		public new vtkTextMapper NewInstance()
		{
			vtkTextMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextMapper.vtkTextMapper_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060104AD RID: 66733
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextMapper_ReleaseGraphicsResources_13(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Use these methods when setting font size relative to the renderer's size. These
		/// methods are static so that external classes (e.g., widgets) can easily use them.
		/// </summary>
		// Token: 0x060104AE RID: 66734 RVA: 0x0016B384 File Offset: 0x00169584
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkTextMapper.vtkTextMapper_ReleaseGraphicsResources_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060104AF RID: 66735
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextMapper_RenderOverlay_14(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// Use these methods when setting font size relative to the renderer's size. These
		/// methods are static so that external classes (e.g., widgets) can easily use them.
		/// </summary>
		// Token: 0x060104B0 RID: 66736 RVA: 0x0016B3B4 File Offset: 0x001695B4
		public override void RenderOverlay(vtkViewport arg0, vtkActor2D arg1)
		{
			vtkTextMapper.vtkTextMapper_RenderOverlay_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x060104B1 RID: 66737
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextMapper_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060104B2 RID: 66738 RVA: 0x0016B3F8 File Offset: 0x001695F8
		public new static vtkTextMapper SafeDownCast(vtkObjectBase o)
		{
			vtkTextMapper vtkTextMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextMapper.vtkTextMapper_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextMapper = (vtkTextMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextMapper.Register(null);
				}
			}
			return vtkTextMapper;
		}

		// Token: 0x060104B3 RID: 66739
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextMapper_SetConstrainedFontSize_16(HandleRef pThis, HandleRef arg0, int targetWidth, int targetHeight);

		/// <summary>
		/// Set and return the font size (in points) required to make this mapper fit
		/// in a given
		/// target rectangle (width x height, in pixels). A static version of the method
		/// is also available for convenience to other classes (e.g., widgets).
		/// </summary>
		// Token: 0x060104B4 RID: 66740 RVA: 0x0016B478 File Offset: 0x00169678
		public virtual int SetConstrainedFontSize(vtkViewport arg0, int targetWidth, int targetHeight)
		{
			return vtkTextMapper.vtkTextMapper_SetConstrainedFontSize_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), targetWidth, targetHeight);
		}

		// Token: 0x060104B5 RID: 66741
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextMapper_SetConstrainedFontSize_17(HandleRef arg0, HandleRef arg1, int targetWidth, int targetHeight);

		/// <summary>
		/// Set and return the font size (in points) required to make this mapper fit
		/// in a given
		/// target rectangle (width x height, in pixels). A static version of the method
		/// is also available for convenience to other classes (e.g., widgets).
		/// </summary>
		// Token: 0x060104B6 RID: 66742 RVA: 0x0016B4B0 File Offset: 0x001696B0
		public static int SetConstrainedFontSize(vtkTextMapper arg0, vtkViewport arg1, int targetWidth, int targetHeight)
		{
			return vtkTextMapper.vtkTextMapper_SetConstrainedFontSize_17((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), targetWidth, targetHeight);
		}

		// Token: 0x060104B7 RID: 66743
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextMapper_SetInput_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The input text string to the mapper.
		/// </summary>
		// Token: 0x060104B8 RID: 66744 RVA: 0x0016B4F5 File Offset: 0x001696F5
		public virtual void SetInput(string _arg)
		{
			vtkTextMapper.vtkTextMapper_SetInput_18(base.GetCppThis(), _arg);
		}

		// Token: 0x060104B9 RID: 66745
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextMapper_SetRelativeFontSize_19(HandleRef arg0, HandleRef arg1, IntPtr winSize, IntPtr stringSize, float sizeFactor);

		/// <summary>
		/// Use these methods when setting font size relative to the renderer's size. These
		/// methods are static so that external classes (e.g., widgets) can easily use them.
		/// </summary>
		// Token: 0x060104BA RID: 66746 RVA: 0x0016B508 File Offset: 0x00169708
		public static int SetRelativeFontSize(vtkTextMapper arg0, vtkViewport arg1, IntPtr winSize, IntPtr stringSize, float sizeFactor)
		{
			return vtkTextMapper.vtkTextMapper_SetRelativeFontSize_19((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), winSize, stringSize, sizeFactor);
		}

		// Token: 0x060104BB RID: 66747
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextMapper_SetTextProperty_20(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Set/Get the text property.
		/// </summary>
		// Token: 0x060104BC RID: 66748 RVA: 0x0016B550 File Offset: 0x00169750
		public virtual void SetTextProperty(vtkTextProperty p)
		{
			vtkTextMapper.vtkTextMapper_SetTextProperty_20(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x060104BD RID: 66749
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextMapper_ShallowCopy_21(HandleRef pThis, HandleRef m);

		/// <summary>
		/// Shallow copy of an actor.
		/// </summary>
		// Token: 0x060104BE RID: 66750 RVA: 0x0016B580 File Offset: 0x00169780
		public override void ShallowCopy(vtkAbstractMapper m)
		{
			vtkTextMapper.vtkTextMapper_ShallowCopy_21(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012EF RID: 4847
		public new const string MRFullTypeName = "Kitware.VTK.vtkTextMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012F0 RID: 4848
		public new static readonly string MRClassNameKey = "class vtkTextMapper";
	}
}
