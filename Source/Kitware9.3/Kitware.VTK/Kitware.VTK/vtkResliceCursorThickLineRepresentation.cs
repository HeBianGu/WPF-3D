using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkResliceCursorThickLineRepresentation
	/// </summary>
	/// <remarks>
	///    represents a thick slab of the reslice cursor widget
	///
	/// This class represents a thick reslice cursor, that can be used to
	/// perform interactive thick slab MPR's through data. The class internally
	/// uses vtkImageSlabReslice to do its reslicing. The slab thickness is set
	/// interactively from the widget. The slab resolution (ie the number of
	/// blend points) is set as the minimum spacing along any dimension from
	/// the dataset.
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageSlabReslice vtkResliceCursorLineRepresentation vtkResliceCursorWidget
	/// </seealso>
	// Token: 0x0200036C RID: 876
	public class vtkResliceCursorThickLineRepresentation : vtkResliceCursorLineRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06009F47 RID: 40775 RVA: 0x000E1F40 File Offset: 0x000E0140
		static vtkResliceCursorThickLineRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkResliceCursorThickLineRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkResliceCursorThickLineRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06009F48 RID: 40776 RVA: 0x000E1F68 File Offset: 0x000E0168
		public vtkResliceCursorThickLineRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06009F49 RID: 40777
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorThickLineRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06009F4A RID: 40778 RVA: 0x000E1F78 File Offset: 0x000E0178
		public new static vtkResliceCursorThickLineRepresentation New()
		{
			vtkResliceCursorThickLineRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorThickLineRepresentation.vtkResliceCursorThickLineRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkResliceCursorThickLineRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06009F4B RID: 40779 RVA: 0x000E1FCC File Offset: 0x000E01CC
		public vtkResliceCursorThickLineRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkResliceCursorThickLineRepresentation.vtkResliceCursorThickLineRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009F4C RID: 40780 RVA: 0x000E2010 File Offset: 0x000E0210
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009F4D RID: 40781
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorThickLineRepresentation_CreateDefaultResliceAlgorithm_01(HandleRef pThis);

		/// <summary>
		/// INTERNAL - Do not use
		/// Create the thick reformat class. This overrides the superclass
		/// implementation and creates a vtkImageSlabReslice instead of a
		/// vtkImageReslice.
		/// </summary>
		// Token: 0x06009F4E RID: 40782 RVA: 0x000E201B File Offset: 0x000E021B
		public virtual void CreateDefaultResliceAlgorithm()
		{
			vtkResliceCursorThickLineRepresentation.vtkResliceCursorThickLineRepresentation_CreateDefaultResliceAlgorithm_01(base.GetCppThis());
		}

		// Token: 0x06009F4F RID: 40783
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkResliceCursorThickLineRepresentation_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06009F50 RID: 40784 RVA: 0x000E202C File Offset: 0x000E022C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkResliceCursorThickLineRepresentation.vtkResliceCursorThickLineRepresentation_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06009F51 RID: 40785
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkResliceCursorThickLineRepresentation_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06009F52 RID: 40786 RVA: 0x000E204C File Offset: 0x000E024C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkResliceCursorThickLineRepresentation.vtkResliceCursorThickLineRepresentation_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06009F53 RID: 40787
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorThickLineRepresentation_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06009F54 RID: 40788 RVA: 0x000E2068 File Offset: 0x000E0268
		public override int IsA(string type)
		{
			return vtkResliceCursorThickLineRepresentation.vtkResliceCursorThickLineRepresentation_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06009F55 RID: 40789
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorThickLineRepresentation_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06009F56 RID: 40790 RVA: 0x000E2088 File Offset: 0x000E0288
		public new static int IsTypeOf(string type)
		{
			return vtkResliceCursorThickLineRepresentation.vtkResliceCursorThickLineRepresentation_IsTypeOf_05(type);
		}

		// Token: 0x06009F57 RID: 40791
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorThickLineRepresentation_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06009F58 RID: 40792 RVA: 0x000E20A4 File Offset: 0x000E02A4
		public new vtkResliceCursorThickLineRepresentation NewInstance()
		{
			vtkResliceCursorThickLineRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorThickLineRepresentation.vtkResliceCursorThickLineRepresentation_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkResliceCursorThickLineRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009F59 RID: 40793
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorThickLineRepresentation_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06009F5A RID: 40794 RVA: 0x000E2100 File Offset: 0x000E0300
		public new static vtkResliceCursorThickLineRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkResliceCursorThickLineRepresentation vtkResliceCursorThickLineRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorThickLineRepresentation.vtkResliceCursorThickLineRepresentation_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkResliceCursorThickLineRepresentation = (vtkResliceCursorThickLineRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkResliceCursorThickLineRepresentation.Register(null);
				}
			}
			return vtkResliceCursorThickLineRepresentation;
		}

		// Token: 0x06009F5B RID: 40795
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorThickLineRepresentation_SetResliceParameters_09(HandleRef pThis, double outputSpacingX, double outputSpacingY, int extentX, int extentY);

		/// <summary>
		/// INTERNAL - Do not use
		/// Reslice parameters which are set from vtkResliceCursorWidget based on
		/// user interactions.
		/// </summary>
		// Token: 0x06009F5C RID: 40796 RVA: 0x000E217F File Offset: 0x000E037F
		public virtual void SetResliceParameters(double outputSpacingX, double outputSpacingY, int extentX, int extentY)
		{
			vtkResliceCursorThickLineRepresentation.vtkResliceCursorThickLineRepresentation_SetResliceParameters_09(base.GetCppThis(), outputSpacingX, outputSpacingY, extentX, extentY);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CDB RID: 3291
		public new const string MRFullTypeName = "Kitware.VTK.vtkResliceCursorThickLineRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CDC RID: 3292
		public new static readonly string MRClassNameKey = "class vtkResliceCursorThickLineRepresentation";
	}
}
